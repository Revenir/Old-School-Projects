# Name: Sebastian Rock
# Class: CS 121 01
# Due Date: March 1 2013
# Description: Plays a trivia game with different categories, a game over screen,
# and the ability to replay the game and choose another category.

import sys, pygame
from pygame.locals import *

class Trivia(object):
    def __init__(self, filename):
        self.data = [] # Holds questions
        self.current = 0 # Move from one question record to the next
        self.total = 0 # Total lines in program
        self.correct = 0
        self.score = 0 # Amount of questions answered correctly
        self.scored = False
        self.failed = False
        self.wronganswer = 0 
        self.colors = [white,white,white,white]

        #read trivia data from file
        f = open(filename, "r")
        trivia_data = f.readlines()
        f.close()

        #count and clean up trivia data
        for text_line in trivia_data:
            self.data.append(text_line.strip()) # Adds each line into a list
            self.total += 1 # Keeps a total of the lines in the list

    def show_question(self):
        print_text(font1, 210, 5, "TRIVIA GAME")
        print_text(font2, 190, 500-20, "Press Keys (1-4) To Answer", purple)
        print_text(font2, 530, 5, "SCORE", purple)
        print_text(font2, 550, 25, str(self.score), purple)

        #get correct answer out of data (first)
        self.correct = int(self.data[self.current+5])

        #display question
        question = self.current // 6 + 1
        print_text(font1, 5, 80, "QUESTION " + str(question))
        print_text(font2, 20, 120, self.data[self.current], yellow)

        #respond to correct answer
        if self.scored:
            self.colors = [white,white,white,white]
            self.colors[self.correct-1] = green
            print_text(font1, 230, 380, "CORRECT!", green)
            print_text(font2, 170, 420, "Press Enter For Next Question", green)
        elif self.failed:
            self.colors = [white,white,white,white]
            self.colors[self.wronganswer-1] = red
            self.colors[self.correct-1] = green
            print_text(font1, 220, 380, "INCORRECT!", red)
            print_text(font2, 170, 420, "Press Enter For Next Question", red)

        #display answers
        print_text(font1, 5, 170, "ANSWERS")
        print_text(font2, 20, 210, "1 - " + self.data[self.current+1], self.colors[0])
        print_text(font2, 20, 240, "2 - " + self.data[self.current+2], self.colors[1])
        print_text(font2, 20, 270, "3 - " + self.data[self.current+3], self.colors[2])
        print_text(font2, 20, 300, "4 - " + self.data[self.current+4], self.colors[3])

    def endgame(self): # Game over function
        print_text(font1, 210, 5, "TRIVIA GAME")
        print_text(font2, 530, 5, "SCORE", purple)
        print_text(font2, 550, 25, str(self.score), purple)

        print_text(font2, 20, 210, "Play again?", white) # Ask to replay
        print_text(font2, 20, 240, "1 - Yes", white)
        print_text(font2, 20, 270, "2 - No", white)

    def handle_input(self,number):
        if not self.scored and not self.failed:
            if number == self.correct:
                self.scored = True
                self.score += 1
            else:
                self.failed = True
                self.wronganswer = number

    def next_question(self):
        if self.scored or self.failed:
            self.scored = False
            self.failed = False
            self.correct = 0
            self.colors = [white,white,white,white]
            self.current += 6
            if self.current >= self.total:
               self.current = 0
            global lines # keeps the lines consistent
            lines +=6


def print_text(font, x, y, text, color=(255,255,255), shadow=True):
    if shadow:
        imgText = font.render(text, True, (0,0,0))
        screen.blit(imgText, (x-2,y-2))
    imgText = font.render(text, True, color)
    screen.blit(imgText, (x,y))

def showcategories():
    print_text(font2, 20, 210, "Please Choose a Category", white)
    print_text(font2, 20, 240, "1 - Astronomy", white)
    print_text(font2, 20, 270, "2 - Tumblr", white)
    print_text(font2, 20, 300, "3 - Mass Effect", white)
    print_text(font2, 20, 330, "4 - Game of Thrones", white)

def showtotal(totalscore): # Function to display the total game score
    print_text(font2, 400, 45, "SCORE FOR ALL GAMES", purple)
    print_text(font2, 550, 65, str(totalscore), purple)    
    
def playgame(totalscore): # create a function that plays the game
    global lines # keeps the variable lines consistant
    lines = 0 # used to count down how many lines have been read in the file
    choice = False # just a variable to keep the loop going
    genre = None # A variable used to store the name of the text file
    selected = False # A variable that checks if a category has been selected
    while choice != True: # this is just a loop to contain everything
        for event in pygame.event.get():
            if event.type == QUIT:
                pygame.quit()
            elif event.type == KEYUP:
                if event.key == pygame.K_ESCAPE:
                    sys.exit()
                elif event.key == pygame.K_1:
                    genre = "trivia_data.txt"
                    selected = True
                elif event.key == pygame.K_2:
                    genre = "tumblr.txt"
                    selected = True
                elif event.key == pygame.K_3:
                    genre = "masseffect.txt"
                    selected = True
                elif event.key == pygame.K_4:
                    genre = "gameofthrones.txt"
                    selected = True

        #clear the screen
        screen.fill((0,0,200))

        showcategories() # shows the caregory screen
        
        #update the display
        pygame.display.update()
        
        #load the trivia data file
        if selected == True: # once selected, a new loop inside the loop is started
            trivia = Trivia(genre)

        #repeating loop
            while selected == True:
                while lines < trivia.total:
                    for event in pygame.event.get():
                        if event.type == QUIT:
                            pygame.quit()
                        elif event.type == KEYUP:
                            if event.key == pygame.K_ESCAPE:
                                sys.exit()
                            elif event.key == pygame.K_1:
                                trivia.handle_input(1)
                            elif event.key == pygame.K_2:
                                trivia.handle_input(2)
                            elif event.key == pygame.K_3:
                                trivia.handle_input(3)
                            elif event.key == pygame.K_4:
                                trivia.handle_input(4)  
                            elif event.key == pygame.K_RETURN:
                                if trivia.scored == True: # checks to see if the answer was right
                                    totalscore += 1 # adds a point to the total score for all games played
                                trivia.next_question()
                    

                    if lines < trivia.total:
                        #clear the screen
                        screen.fill((0,0,200))

                        #display trivia data
                        trivia.show_question()
        
                        #update the display
                        pygame.display.update()            

                else:
                    for event in pygame.event.get():
                        if event.type == QUIT:
                            pygame.quit()
                        elif event.type == KEYUP:
                            if event.key == pygame.K_ESCAPE:
                                pygame.quit()
                            elif event.key == pygame.K_1:
                                playgame(totalscore) # restarts the function
                                
                            elif event.key == pygame.K_2:
                                pygame.quit()  
            
                    #clear the screen
                    screen.fill((0,0,200))

                    #display trivia data
                    showtotal(totalscore) # shows the total score for all games
                    trivia.endgame() # asks player if they want to play again
        
                    #update the display
                    pygame.display.update()            
    
#main program begins
pygame.init()
screen = pygame.display.set_mode((600,500))
pygame.display.set_caption("The Trivia Game")
font1 = pygame.font.Font(None, 40)
font2 = pygame.font.Font(None, 24)
white = 255,255,255
cyan = 0,255,255
yellow = 255,255,0
purple = 255,0,255
green = 0,255,0
red = 255,0,0

totalscore = 0 # variable for the total score. Needs to be outside the function so it isn't reset
playgame(totalscore) # play the game
