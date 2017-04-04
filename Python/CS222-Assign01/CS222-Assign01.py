
# Class and section: CS 222 01
# Program Assignment 1
# Program Name: CS222Rock-Sebastian-Assign01
# Due Date: 9/16/2013
# Program description: Finds duplicate birthdays in a list to prove the birthday paradox.

import random

print("If more than 23 people are in a room, there is a decent chance the people have a birthday in common!")
population = int(input("Enter the number of people in the room: "))
people = []                         # Make an empty list for the people entering the room

for x in range(population):           
    month = random.randint(1, 12)   # A random month is chosen.
                                    # We need the if statements to make sure we have the right number of days.
    
    if month == 1 or month == 3 or month == 5 or month == 7 or month == 8 or month == 10 or month == 12:
        day = random.randint(1, 31)

    elif month == 2:
        day = random.randint(1, 28) # If we cared about leap years, we could make this 29

    elif month == 4 or month == 6 or month == 9 or month == 11:
        day = random.randint(1, 30)

    person = month, day             # Creates a tuple, since a person's birthday is static
    people.append(person)           # Adds each person in the room to the list of people

twins = set()                       # Since sets do not allow duplicates, this prevents a birthday from showing up more than once.
for birthdays in people:
    if people.count(birthdays) > 1: # people.count counts the number of instances an element pops up in a list.
        twins.add(birthdays)        # Adds duplicate birthday to a list.
        
twins = list(twins)                 # Sets don't support indexing, which we need.
for x in twins:
    if x[0] == 1:                   # Prints out the actual name of the month, just to make it look nicer.
        print("January " + str(x[1]) + " is a duplicate.")
    elif x[0] == 2:
        print("February " + str(x[1]) + " is a duplicate.")
    elif x[0] == 3:
        print("March " + str(x[1]) + " is a duplicate.")
    elif x[0] == 4:
        print("April " + str(x[1]) + " is a duplicate.")
    elif x[0] == 5:
        print("May " + str(x[1]) + " is a duplicate.")
    elif x[0] == 6:
        print("June " + str(x[1]) + " is a duplicate.")
    elif x[0] == 7:
        print("July " + str(x[1]) + " is a duplicate.")
    elif x[0] == 8:
        print("August " + str(x[1]) + " is a duplicate.")
    elif x[0] == 9:
        print("September " + str(x[1]) + " is a duplicate.")
    elif x[0] == 10:
        print("October " + str(x[1]) + " is a duplicate.")
    elif x[0] == 11:
        print("November " + str(x[1]) + " is a duplicate.")
    elif x[0] == 12:
        print("December " + str(x[1]) + " is a duplicate.")

if not twins:                       # If the list is empty, we print out a different message.
    print("There are no birthdays in common!")

input("\nPress the enter key to exit.")
    
