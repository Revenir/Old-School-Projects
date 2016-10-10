# Name: Sebastian Rock
# Class and section: CS 222 01
# Program Assignment 2
# Program Name: river2.py
# Due Date: 9/30/2013
# Program description: Creates a simulation of a river.

import random

class Ecosystem():
    def __init__(self):
        self.species = " "
        self.movement = "NOWHERE"

    def getSpecies(self):
        return self.species

    def getMovement(self):
        return self.movement

    def setSpecies(self, x):
        if x == 1:
            self.species = "Bear"
        elif x == 2:
            self.species = "Fish"
        else:
            self.species = "<none>"

    def setMovement(self, x):
        if self.species == "Bear" or self.species == "Fish":
            if x == 1:
                self.movement = "RIGHT"
            elif x == 2:
                self.movement = "LEFT"
            else:
                self.movement = "NOWHERE"
        else:
            self.movement = "NOWHERE"
        
    def __eq__(self, x):
        if self.species == x.species:
            return True
        else:
            return False
        
    def __str__(self):
        return "I'm a " + self.species + " and I want to move " + str(self.movement)

def breed(x, y):
    empties = []
    for i in range(len(x)):
        if x[i].species == "<none>":    # Finds all the empty places in list
            empties.append(i)           # Adds there indices to a new list

    if empties:         # Checks to see if there are empty spaces
        z = random.randint(0, (len(empties)-1)) # Picks a random empty space
        chosen = empties[z]       
        if x[y].species == "Bear":
            x[chosen].setSpecies(1)
        else:
            x[chosen].setSpecies(2)
    else:
        if x[y].species == "Bear":
            Bear = Ecosystem()
            Bear.setSpecies(1)
            x.append(Bear)
        else:
            Fish = Ecosystem()
            Fish.setSpecies(2)
            x.append(Fish)

def battle(x, y, z):
    if x[y].species == "Fish":
        x[y].setSpecies(3)
    else:
        x[z].setSpecies(3)

def moveRight(x, y):
    if x[y] == x[y + 1]:
        breed(x, y)
    else:
        if x[y + 1].species == "<none>":
            if x[y].species == "Bear":
                x[y + 1].setSpecies(1)
            else:
                x[y + 1].setSpecies(2)
            x[y].setSpecies(3)
        else:
            battle(x, y, y-1)

def moveLeft(x, y):
    if x[y] == x[y - 1]:
        breed(x, y)
    else:
        if x[y - 1].species == "<none>":
            if x[y].species == "Bear":
                x[y - 1].setSpecies(1)
            else:
                x[y - 1].setSpecies(2)
            x[y].setSpecies(3)
        else:
            battle(x, y, y-1)
    
river = []
listlength = random.randint(50, 1000) # Could change this to a user input

for i in range(listlength):
    j = random.randint(1, 3)
    if j == 1:
        Bear = Ecosystem()
        Bear.setSpecies(1)
        river.append(Bear)
        
    elif j == 2:
        Fish = Ecosystem()
        Fish.setSpecies(2)
        river.append(Fish)
        
    else:
        Empty = Ecosystem()
        Empty.setSpecies(3)
        river.append(Empty)


cycles = int(input("\nHow many times do you want the program to run? "))
currentcycle = 1

while cycles > 0:
    print("\n------------------")
    print("CYCLE ", currentcycle)
    print("---------------------")
    
    for animals in range(len(river)):
        if animals >= (len(river) - 1):
            z = random.randint(2,3)
        elif animals == 0:
            z = random.randint(0,1)
        else:
            z = random.randint(1,3)
        river[animals].setMovement(z)

    for animals in range(len(river)):
        if river[animals].movement == "RIGHT":
            moveRight(river, animals)
        if river[animals].movement == "LEFT":
            moveLeft(river, animals)

    bearcount = 0
    fishcount = 0
    for animals in range(len(river)):
        if river[animals].species == "Bear":
            bearcount += 1
        elif river[animals].species == "Fish":
            fishcount += 1
    
    print("\nNumber of bears: ", bearcount)
    print("Number of fish: ", fishcount)
    print("----------------------")
        
    cycles -= 1
    currentcycle += 1
    
    

