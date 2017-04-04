
# Class: CS 121 01
# Due date: May 8, 2013
# Description: A simple shooter game which uses ship sprites, bullet sprites which
# collide with the ships, shooting noises when the ships fire their bullets,
# and timing to update the screen.

import sys, random, math, pygame
from pygame.locals import *

class MySprite(pygame.sprite.Sprite):
    def __init__(self):
        pygame.sprite.Sprite.__init__(self)

        self.image = None
        self.frame = 0
        self.old_frame = -1
        self.width = 1
        self.height = 1
        self.first_frame = 0
        self.last_frame = 0
        self.columns = 1
        self.last_time = 0
        self.direction = 0
        self.velocity = Point(0.0,0.0) 
        
    def _getx(self): return self.rect.x
    def _setx(self,value): self.rect.x = value
    X = property(_getx,_setx)

    #Y property
    def _gety(self): return self.rect.y
    def _sety(self,value): self.rect.y = value
    Y = property(_gety,_sety)

    #position property
    def _getpos(self): return self.rect.topleft
    def _setpos(self,pos): self.rect.topleft = pos
    position = property(_getpos,_setpos)


    def load(self, filename, width, height):
        self.image = pygame.image.load(filename).convert_alpha()
        self.width = width
        self.height = height
        self.rect = Rect(0,0,width,height)
        #try to auto-calculate total frames
        rect = self.image.get_rect()
        
    def update(self, current_time, rate=30):
        #update animation frame number
        if current_time > self.last_time + rate:
            self.frame += 1
            if self.frame > self.last_frame:
                self.frame = self.first_frame
            self.last_time = current_time

        #build current frame only if it changed
        if self.frame != self.old_frame:
            frame_x = (self.frame % self.columns) * self.width
            frame_y = (self.frame // self.columns) * self.height
            rect = Rect(frame_x, frame_y, self.width, self.height)
            self.image = self.image.subsurface(rect)
            self.old_frame = self.frame
        
class Point(object):
    def __init__(self, x, y):
        self.__x = x
        self.__y = y

    #X property
    def getx(self): return self.__x
    def setx(self, x): self.__x = x
    x = property(getx, setx)

    #Y property
    def gety(self): return self.__y
    def sety(self, y): self.__y = y
    y = property(gety, sety)

    def __str__(self):
        return "{X:" + "{:.0f}".format(self.__x) + \
            ",Y:" + "{:.0f}".format(self.__y) + "}"

def calc_velocity(direction, vel=4.0):
    velocity = Point(0,0)
    if direction == 0: #north
        velocity.y = -vel
    elif direction == 2: #east
        velocity.x = vel
    elif direction == 4: #south
        velocity.y = vel
    elif direction == 6: #west
        velocity.x = -vel
    return velocity

def reverse_direction(sprite):
    if sprite.direction == 0:
        sprite.direction = 4
    elif sprite.direction == 2:
        sprite.direction = 6
    elif sprite.direction == 4:
        sprite.direction = 0
    elif sprite.direction == 6:
        sprite.direction = 2
        
# prints text using the supplied font
def print_text(font, x, y, text, color=(255,255,255)):
    imgText = font.render(text, True, color)
    screen.blit(imgText, (x,y))

def audio_init():
    global shoot_sound, boom_sound

    #initialize the audio mixer
    pygame.mixer.init() 

    #load sound files
    shoot_sound = pygame.mixer.Sound("shoot.wav")
    boom_sound = pygame.mixer.Sound("boom.wav")

def play_sound(sound):
    channel = pygame.mixer.find_channel(True)
    channel.set_volume(0.5)
    channel.play(sound)
   
player_group = pygame.sprite.Group()
enemy_group = pygame.sprite.Group()
ebullet_group = pygame.sprite.Group()
bullet_group = pygame.sprite.Group()
pygame.init()
audio_init()
timer = pygame.time.Clock()
font = pygame.font.Font(None, 30)

screen = pygame.display.set_mode([800, 600])
space = pygame.image.load("space.png").convert_alpha()
planet = pygame.image.load("planet2.png").convert_alpha()
s = MySprite()
s.load("ship2.png", 175, 175)
s.position = 0,0
s.direction = 4
player_group.add(s)

a = int(s.X + 180)
z = int(s.Y)
pshell = MySprite()
pshell.load("bullet.png", 50, 17)
pshell.position = a, z
pshell.direction = 4
bullet_group.add(pshell)

e = MySprite()
e.load("military.png", 175, 175)
e.position = 600,0
e.direction = 4
enemy_group.add(e)

eshell = MySprite()
eshell.load("ebullet.png", 175, 175)
eshell.position = 600,0
eshell.direction = 4
ebullet_group.add(eshell)

screen.blit(space, (0,0))
width,height = planet.get_size()
screen.blit(planet, (400-width/2,300-height/2))
game_over = False
player_health = 100
player_score = 0

enemy_firing = False
player_firing = False

while True:
    timer.tick(30)
    ticks = pygame.time.get_ticks()
    
    for event in pygame.event.get():
        if event.type == QUIT:
            pygame.quit()
    keys = pygame.key.get_pressed()
    if keys[K_ESCAPE]:
        pygame.quit()
    elif keys[K_RIGHT]:
        s.direction = 2
        player_moving = True
    elif keys[K_LEFT]:
        s.direction = 6
        player_moving = True
    elif keys[K_UP]:
        s.direction = 0
        player_moving = True
    elif keys[K_DOWN]:
        s.direction = 4
        player_moving = True
    else:
        player_moving = False
    if keys[K_SPACE]:
        if not player_firing:
            play_sound(shoot_sound)
            player_firing = True
            playerOldPos = s.Y + 90
    if keys[K_RETURN]:
        if game_over:
            player_health = 100
            player_score = 0
            game_over = False

    if not game_over:
        if player_moving:
            #move player in direction 
            s.velocity = calc_velocity(s.direction, 1.5)
            s.velocity.x *= 1.5
            s.velocity.y *= 1.5

        e.velocity.y += random.randint(-1, 1)
        if e.Y <= 10:
            e.velocity.y = random.randint(0, 1)
        elif e.Y >= 490:
            e.velocity.y = random.randint(-1, 0)
        e.Y += e.velocity.y

        s.update(ticks, 50)
        e.update(ticks, 50)

        # Has the enemy hit the player?
        if pygame.sprite.collide_rect(eshell, s):
            player_health -= 5
            enemy_firing = False
            i = int(e.X - 40)
            u = int(e.Y)
            eshell.position = i,u
            eshell.velocity.x = 0.0

        # Has the player hit the enemy?
        if pygame.sprite.collide_rect(pshell, e):
            player_score += 1
            player_firing = False
            a = int(s.X + 180)
            z = int(s.Y)
            pshell.position = a,z
            eshell.velocity.x = 0.0

        if player_moving:
            s.X += s.velocity.x
            s.Y += s.velocity.y
            if s.X < 0: s.X = 0
            elif s.X > 100: s.X = 100
            if s.Y < 0: s.Y = 0
            elif s.Y > 500: s.Y = 500

        if player_firing:
            pshell.X += pshell.velocity.x
            pshell.Y = playerOldPos

            if pshell.velocity.x < 10.0:
                pshell.velocity.x += 0.1

            #has shell gone off the screen?            
            if pshell.X >= 799:
                player_firing = False
                a = int(s.X + 180)
                z = int(s.Y)
                pshell.position = a,z
                pshell.velocity.x = 0.0

        if enemy_firing:
            eshell.X -= eshell.velocity.x
            eshell.Y = enemyOldPos

            if eshell.velocity.x < 10.0:
                eshell.velocity.x += 0.1
                
            if eshell.X <= 0:
                enemy_firing = False
                i = int(e.X - 40)
                u = int(e.Y)
                eshell.position = i,u
                eshell.velocity.x = 0.0
        else:
            play_sound(shoot_sound)
            enemy_firing = True
            enemyOldPos = e.Y + 90


        #Reset the screen        
        screen.blit(space, (0,0))
        screen.blit(planet, (400-width/2,300-height/2))

        if player_firing:
            bullet_group.draw(screen)

        if enemy_firing:
            ebullet_group.draw(screen)

        #Draw sprites
        player_group.draw(screen)
        enemy_group.draw(screen)
        
    
        #Draw Health
        pygame.draw.rect(screen, (50,150,50,180), Rect(300,570,player_health*2,25))
        pygame.draw.rect(screen, (100,200,100,180), Rect(300,570,200,25), 2)
        print_text(font, 0, 0, "PLAYER " + str(player_score))

    #is player dead?
    if player_health <= 0:
        play_sound(boom_sound)
        game_over = True
        
    if game_over:
        print_text(font, 300, 100, "G A M E   O V E R")
        print_text(font, 300, 300, "Press enter to continue")
        
    pygame.display.update()
