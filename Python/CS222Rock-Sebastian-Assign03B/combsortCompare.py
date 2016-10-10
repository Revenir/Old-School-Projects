# Name: Sebastian Rock
# Class: CS 222
# Date: 11/6/2013
# File name: combsortCompare.py
# Description: Compares the different methods of sorting lists.

import random
import time

def update_gap(gap):
    gap = (gap * 10) // 13
    if gap == 9 or gap == 10:
        gap = 11
    return max(1, gap)

def swap(lyst, i, j):
    """Exchanges the elements at positions i and j."""
    #profiler.exchange()
    temp = lyst[i]
    lyst[i] = lyst[j]
    lyst[j] = temp

def printList(lyst):
    count = 0
    for x in range(len(lyst) - 1):
        count += 1
        print("%6d" % lyst[x], end=" ")
        if count == 10:
            print()
            count = 0
    
def combSort(x, data):
    comparison, switch = data
    gap = len(x)
    swapped = True
    if gap < 2:
        return
    while gap > 1 or swapped:
        gap = update_gap(gap)
        swapped = False
        for i in range(0, len(x) - gap, gap):
            comparison += 1
            if x[i] > x[i + gap]:
                switch += 1
                swap(x, i, i + gap)
                swapped = True
                
    data = comparison, switch
    return data
    
def insertionSort(lyst, data):
    comparison, switch = data
    i = 1
    while i < len(lyst):
        itemToInsert = lyst[i]
        j = i - 1
        while j >= 0:
            comparison += 1
            if itemToInsert < lyst[j]:
                switch += 1
                lyst[j + 1] = lyst[j]
                j -= 1
            else:
                break
        lyst[j + 1] = itemToInsert
        i += 1
    data = comparison, switch
    return data

def bubbleSort(lyst, data):
    comparison, switch = data
    n = len(lyst)
    while n > 1:
        sortComplete = True
        i = 1
        while i < n:
            comparison += 1
            if lyst[i] < lyst[i - 1]:
                switch += 1
                swap(lyst, i, i - 1)
            i += 1
        if sortComplete:
            data = comparison, switch
            return data
        n -= 1
    data = comparison, switch
    return data
        
def selectionSort(lyst, data):
    comparison, switch = data
    i = 0
    while i < len(lyst) - 1:         # Do n - 1 searches
        minIndex = i                 # for the largest
        j = i + 1                    
        while j < len(lyst):         # Start a search
            comparison += 1
            if lyst[j] < lyst[minIndex]:
                minIndex = j
            j += 1
        if minIndex != i:            # Exchange if needed
            switch += 1
            swap(lyst, minIndex, i)
        i += 1
    data = comparison, switch
    return data

def compareSelection(listLength):
    lyst = []
    for x in range(listLength):
        lyst.append(random.randint(1, 5000))

    comparison = 0
    switch = 0
    data = comparison, switch
    startTime = time.time()
    data = selectionSort(lyst, data)
    elapsedTime = time.time() - startTime
    comparison, switch = data
    print("Elapsed time", elapsedTime)
    print("Number of comparison:", comparison)
    print("Number of switches:", switch)
    #printList(lyst)


def compareBubble(listLength):
    lyst = []
    for x in range(listLength):
        lyst.append(random.randint(1, 5000))
    #lyst.sort()
    comparison = 0
    switch = 0
    data = comparison, switch
    startTime = time.time()
    data = bubbleSort(lyst, data)
    elapsedTime = time.time() - startTime
    comparison, switch = data
    print("Elapsed time", elapsedTime)
    print("Number of comparison:", comparison)
    print("Number of switches:", switch)

def compareInsertion(listLength):
    lyst = []
    for x in range(listLength):
        lyst.append(random.randint(1, 5000))
    #lyst.sort()
    comparison = 0
    switch = 0
    data = comparison, switch
    startTime = time.time()
    data = insertionSort(lyst, data)
    elapsedTime = time.time() - startTime
    comparison, switch = data
    print("Elapsed time", elapsedTime)
    print("Number of comparison:", comparison)
    print("Number of switches:", switch)

def compareComb(listLength):
    lyst = []
    for x in range(listLength):
        lyst.append(random.randint(1, 5000))
    #lyst.sort()
    comparison = 0
    switch = 0
    data = comparison, switch
    startTime = time.time()
    data = combSort(lyst, data)
    elapsedTime = time.time() - startTime
    comparison, switch = data
    print("Elapsed time", elapsedTime)
    print("Number of comparison:", comparison)
    print("Number of switches:", switch)

def main():
    print("\nCompare Comb")
    print("\nList length 100: ")
    compareComb(100)
    print("\nList length 1000: ")
    compareComb(1000)
    print("\nList length 5000: ")
    compareComb(5000)
    print("\nList length 10000: ")
    compareComb(10000)

    print("\nCompare Bubble")
    print("\nList length 100: ")
    compareBubble(100)
    print("\nList length 1000: ")
    compareBubble(1000)
    print("\nList length 5000: ")
    compareBubble(5000)
    print("\nList length 10000: ")
    compareBubble(10000)
    
    print("\nCompare Selection")
    print("\nList length 100: ")
    compareSelection(100)
    print("\nList length 1000: ")
    compareSelection(1000)
    print("\nList length 5000: ")
    compareSelection(5000)
    print("\nList length 10000: ")
    compareSelection(10000)

    print("\nCompare Insertion")
    print("\nList length 100: ")
    compareInsertion(100)
    print("\nList length 1000: ")
    compareInsertion(1000)
    print("\nList length 5000: ")
    compareInsertion(5000)
    print("\nList length 10000: ")
    compareInsertion(10000)
    
main()
