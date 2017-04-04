
#Class and Section – CS 222 01
#Program Assignment – 03A
#Program Name – sqrtEstimator.py
#Due Date – 10/14/2013
#Program Description – Calculates square root iteratively, recursively,
# and using Python's built in fuction.

import math

def sqrtEstimator(number, estimate, tolerance):
    difference = abs(number - estimate ** 2)
    
    if tolerance >= difference:
        return estimate
    else:
        return sqrtEstimator(number, ((estimate + number/estimate)/2), tolerance)
    
   
x = float(input("Enter a positive number: "))
tolerance = 0.000001
estimate = 1.0

# Calls the recursive function
recursive = sqrtEstimator(x, estimate, tolerance)

# Does things using iteration
estimate = (estimate + x / estimate) / 2
difference = abs(x - estimate ** 2)
while difference > tolerance:
    estimate = (estimate + x / estimate) / 2
    difference = abs(x - estimate ** 2)
    
print("The iterative estimate:", estimate)
print("The recursive estimate:", recursive)
print("Python's estimate:     ", math.sqrt(x))
