# Name: Sebastian Rock
# Class: CS 121
# Date: 2/8/2013
# Program Name: Critter Caretaker
# Description: A virtual pet to care for

import random

class Critter(object):
    """A virtual pet"""
    def __init__(self, name, hunger = 0, boredom = 0):
        self.name = name
        self.hunger = hunger
        self.boredom = boredom

    def __pass_time(self):
        self.hunger += 1
        self.boredom += 1

    @property
    def mood(self):
        unhappiness = self.hunger + self.boredom
        if unhappiness < 5:
            m = "happy"
        elif 5 <= unhappiness <= 10:
            m = "okay"
        elif 11 <= unhappiness <= 15:
            m = "frustrated"
        else:
            m = "mad"

        return m
    
    def talk(self):
        print("\nHi, I'm", self.name, "and I feel", self.mood, "now\n")
        self.__pass_time()

    def eat(self):
        food, bored = meal()
        print("Brruppp. Thank you.")
        self.hunger -= food
        self.boredom += bored
        if self.hunger <0:
            self.hunger = 0
        self.__pass_time()

    def play(self):
        fun, starvation = play()
        print("Wheee!")
        self.boredom -= fun
        self.hunger += starvation
        if self.boredom < 0:
            self.boredom = 0
        self.__pass_time()

def meal():
    # If you give it more food, it gets more bored so there's a consequence
    if foodchoice == "0":
        food = random.randint(0, 4)
        bored = random.randint(0, 4)

    elif foodchoice == "1":
        food = random.randint(0, 8)
        bored = random.randint(0, 8)

    elif foodchoice == "2":
        food = random.randint(0, 12)
        bored = random.randint(0, 12)

    elif foodchoice == "3":
        food = random.randint(0, 16)
        bored = random.randint(0, 16)

    else:
        print("Invalid choice.")
        choice = input("Your choice: ")

    return food, bored

def play():
    # If you play with it longer, it gets more hungry so there's a consequence
    if playchoice == "0":
        fun = random.randint(0, 3)
        starvation = random.randint(0, 3)

    elif playchoice == "1":
        fun = random.randint(0, 6)
        starvation = random.randint(0, 6)

    elif playchoice == "2":
        fun = random.randint(0, 9)
        starvation = random.randint(0, 9)
        
    elif playchoice == "3":
        fun = random.randint(0, 12)
        starvation = random.randint(0, 12)

    elif playchoice == "4":
        fun = random.randint(0, 15)
        starvation = random.randint(0, 15)
        
    elif playchoice == "5":
        fun = random.randint(0, 18)
        starvation = random.randint(0, 18)

    else:
        print("Invalid choice.")
        choice = input("Your choice: ")

    return fun, starvation

def main():
    # Make the variables that will be used in the future global 
    # so they can be used in the function
    global foodchoice
    global playchoice
    # List to keep track of the farm
    farm = []
    count = int(input("How many critters do you want in your farm?: "))
    for x in range(count):  
        crit_name = input("What do you want to name your critter?: ")
        # Each critter has a different starting disposition
        startfood = random.randint(0, 40)
        startmood = random.randint(0, 40)
        crit = Critter(crit_name, startfood, startmood)
        farm.append(crit)

    choice = None
    while choice != "0":
        print \
        ("""
        Critter Caretaker

        0 - Quit
        1 - Listen to your critter
        2 - Feed your critter
        3 - Play with your critter

        """)
        
        choice = input("Choice: ")
        print()

        # exit
        if choice == "0":
            print("Good-bye.")

        # listen to your critter
        elif choice == "1":
            for x in range(count):
                farm[x].talk()

        # feed your critter
        elif choice == "2":
            print \
            ("""
            How much food would you like to give your critter?

            0 - One Quarter of a bowl
            1 - Half a bowl
            2 - Three fourths of a bowl
            3 - A full bowl
            """
            )
            foodchoice = input("Choice: ")
            
            # Each animal will eat
            for x in range(count):
                farm[x].eat()

        # play with your critter
        elif choice == "3":
            print \
            ("""
             How long would you like to play with your pet?

            0 - Ten minutes
            1 - Twenty minutes
            2 - Thirty minutes
            3 - Forty minutes
            4 - Fifty minutes
            5 - One hour
            """)
            
            playchoice = input("Your choice: ")

            # Each animal will play
            for x in range(count):
                farm[x].play()

        # Some unknown choice
        else:
            print("\nSorry, but", choice, "isn't a valid choice.")

main()
input("\n\nPress the enter key to exit.")
