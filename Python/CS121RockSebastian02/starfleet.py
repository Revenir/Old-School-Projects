# Name: Sebastian Rock
# Class: CS 121 01
# Program: Assignment 02
# Due Date: February 20, 2013
# Description: Draws a starfleet insignia in pygame.

import math
import pygame
from pygame.locals import *

pygame.init()
screen = pygame.display.set_mode((600,500))
pygame.display.set_caption("Starfleet Insignia")

while True:
    for event in pygame.event.get():
        if event.type in (QUIT, KEYDOWN):
            pygame.quit()

    screen.fill((110,110,110))

    # draw a circle
    colorc = 255,255,255
    position = 300,300
    radius = 100
    widthc = 0 # Solid Fill
    pygame.draw.circle(screen, colorc, position, radius, widthc)

    # draw a circle's outline    
    coloro = 0,0,0
    position = 300,300
    radius = 100
    width = 5
    pygame.draw.circle(screen, coloro, position, radius, width)

    # fill the insignia
    colorA = 255,255,255
    position4 = 200,290,250,500
    start_angle4 = math.radians(90)
    end_angle4 = math.radians(150)
    width = 5
    pygame.draw.arc(screen, colorA, position4, start_angle4, end_angle4, width)

    position5 = 200,280,250,500
    start_angle5 = math.radians(90)
    end_angle5 = math.radians(150)
    pygame.draw.arc(screen, colorA, position5, start_angle5, end_angle5, width)

    position6 = 200,270,250,500
    start_angle6 = math.radians(90)
    end_angle6 = math.radians(150)
    pygame.draw.arc(screen, colorA, position6, start_angle5, end_angle5, width)      
    
    # draw a rectangle
    widthR = 0 # Solid Fill
    pos = 260, 200, 80, 50
    pygame.draw.rect(screen, colorA, pos, widthR)

    # draw an ellipse
    pygame.draw.ellipse(screen, colorA, ((265, 153), (70, 100)), 0) # solid fill
    
    # draw the arcs
    color = 0,0,0
    position = 200,300,250,500
    start_angle = math.radians(90)
    end_angle = math.radians(150)
    pygame.draw.arc(screen, color, position, start_angle, end_angle, width)

    color2 = 0,0,0
    position2 = 200,150,200,1200
    start_angle2 = math.radians(35)
    end_angle2 = math.radians(150)
    width2 = 5
    pygame.draw.arc(screen, color2, position2, start_angle2, end_angle2, width2)

    color3 = 0,0,0
    position3 = 230,300,165,400
    start_angle3 = math.radians(30)
    end_angle3 = math.radians(100)
    width3 = 5
    pygame.draw.arc(screen, color3, position3, start_angle3, end_angle3, width3)

    # draw the lines
    color = 0,0,0
    width4 = 3
    pygame.draw.line(screen, color, (305,180), (320,280), width4)

    pygame.draw.line(screen, color, (305,260), (320,280), width4)

    pygame.draw.line(screen, color, (295,280), (305,260), width4)

    pygame.draw.line(screen, color, (295,280), (305,180), width4)

    pygame.draw.line(screen, color, (300,260), (280,250), width4)

    pygame.draw.line(screen, color, (280,250), (300,245), width4)

    pygame.draw.line(screen, color, (315,260), (330,250), width4)

    pygame.draw.line(screen, color, (315,245), (330,250), width4)

    # filling the star
    pygame.draw.line(screen, color, (315,245), (328,252), width4)

    pygame.draw.line(screen, color, (315,245), (326,255), width4)

    pygame.draw.line(screen, color, (315,245), (324,257), width4)

    pygame.draw.line(screen, color, (315,245), (322,258), width4)

    pygame.draw.line(screen, color, (315,245), (320,258), width4)

    pygame.draw.line(screen, color, (305,180), (318,278), width4)

    pygame.draw.line(screen, color, (305,180), (316,274), width4)

    pygame.draw.line(screen, color, (305,180), (314,272), width4)

    pygame.draw.line(screen, color, (305,180), (312,270), width4)

    pygame.draw.line(screen, color, (305,180), (310,268), width4)

    pygame.draw.line(screen, color, (305,180), (308,266), width4)

    pygame.draw.line(screen, color, (305,180), (306,263), width4)

    pygame.draw.line(screen, color, (305,180), (304,264), width4)

    pygame.draw.line(screen, color, (305,180), (302,265), width4)

    pygame.draw.line(screen, color, (305,180), (300,266), width4)

    pygame.draw.line(screen, color, (305,180), (298,268), width4)

    pygame.draw.line(screen, color, (305,180), (295,268), width4)

    pygame.draw.line(screen, color, (305,180), (297,269), width4)

    pygame.draw.line(screen, color, (300,256), (280,250), width4)

    pygame.draw.line(screen, color, (299,254), (280,250), width4)

    pygame.draw.line(screen, color, (299,252), (280,250), width4)

    pygame.draw.line(screen, color, (298,250), (280,250), width4)
    
    pygame.display.update()
