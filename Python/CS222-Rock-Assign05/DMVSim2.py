##Author – Sebastian Rock
##Class and Section – CS 222 01
##Program Assignment – 05
##Program Name - DMVSim2.py
##Due Date - 10 December
##Program Description – Simulates the DMV
import random
from node import Node
from abstractcollection import AbstractCollection

class Clerk():
    def __init__(self, name):
        self.name = name
        self.serviceTime = 0
    def setServiceTime(self):   #Time to help customer
        self.serviceTime = random.randint(5, 8)
    def ServiceCustomer(self):
        if self.serviceTime > 0:
            self.serviceTime -= 1
    
def checkService(DMV, queue):
    for clerk in DMV:
        if clerk.serviceTime <= 0 and queue.isEmpty() is False:
            queue.pop()
            clerk.setServiceTime()
                    
class LinkedQueue(AbstractCollection):
    """A link-based queue implementation."""

    # Constructor
    def __init__(self, sourceCollection = None):
        """Sets the initial state of self, which includes the
        contents of sourceCollection, if it's present."""
        self._front = self._rear = None
        AbstractCollection.__init__(self, sourceCollection)

    # Accessor methods
    def __iter__(self):
        """Supports iteration over a view of self."""
        pass
    
    def peek(self):
        """
        Returns the item at the front of the queue.
        Precondition: the queue is not empty.
        Raises: KeyError if the stack is empty."""
        if self.isEmpty():
            raise KeyError("The queue is empty.")
        return self._front.data

    # Mutator methods
    def clear(self):
        """Makes self become empty."""
        pass
    
    def add(self, item):
        """Adds item to the rear of the queue."""
        newNode = Node(item, None)
        if self.isEmpty():
            self._front = newNode
        else:
            self._rear.next = newNode
        self._rear = newNode
        self._size += 1

    def pop(self):
        """
        Removes and returns the item at the front of the queue.
        Precondition: the queue is not empty.
        Raises: KeyError if the queue is empty.
        Postcondition: the front item is removed from the queue."""
        if self.isEmpty():
            raise KeyError("The queue is empty.")
        oldItem = self._front.data
        self._front = self._front.next
        if self._front is None:
            self._rear = None
        self._size -= 1
        return oldItem

def main():
    Clerk1 = Clerk("Bob")
    Clerk2 = Clerk("Charles")
    Clerk3 = Clerk("Roberta")

    DMV = [Clerk1, Clerk2, Clerk3]
    customerQueueLength = 0
    customerQueue = LinkedQueue()
    newCustomerTime = random.randint(1, 5)

    runtime = int(input("How many minutes will the DMV be open? "))
    while runtime > 0:
        #print("Cycle ", runtime)
        if newCustomerTime <= 0:   # Time is up, new customer is spawned
            customerQueue.add(customerQueueLength)
            customerQueueLength += 1
            newCustomerTime = random.randint(1, 5)
        else:
            newCustomerTime -= 1

        if customerQueue.isEmpty() is False:
            checkService(DMV, customerQueue)

        for clerk in DMV:
            clerk.ServiceCustomer()

        runtime -= 1

    print("Number of customers that entered the DMV ", customerQueueLength)    
    print("Number of customers yet to be served: ", customerQueue.__len__())
    print("Number of customers that have been served: ", customerQueueLength - customerQueue.__len__())
    
    
main()
