# Data Structures Study
2023-02-05

How to organize data? Memory is limited. Write programs in a logical way. 

Big O # **Operations**
    Constant time O(1)
    Linear time O(n)
    Quadratic time O(n^2)
    Logarithmic time O(LOGn)

Arrays # [] # Fixed size, slow, linear
    example = ["a", "b", "c"]
    example.index("a")

Linked list # linked nodes where each node contains a data point and a reference to the next data point in the list # linear
    1 -> 2 -> 3 ->
    def add_note(self, new_data):
    """ adding to the back"""

    # create new node
    new_node = Node(new_data)

    # change pointers
    new_node.next = tail.next
    tail.next = new_node    

Stack & Queue (()) Push/Pop - Stack = Containers distinguised by LIFO retrieval order # linear, Queue = FIFO # linear, no search
def deQueue(self):
    if self.isEmpty():
        print("Queue is Empty")
        return
    self.queue.pop(0)

Hash table {}

Graphs & Trees 

