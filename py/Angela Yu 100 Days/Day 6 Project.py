# Day 6 - Code Blocks, Functions, While Loops (karel the robot)
# basic python functions such as len(), print(), you can also define your own functions (and call them):
def my_function():
    print("Hello")
    print("Bye")
my_function()

# reeborgs world robots
def turn_right():
    turn_left()
    turn_left()
    turn_left()

#draw square
move()
turn_left()
move()
turn_left()
move()
turn_left()
move()

#60,
def turn_right():
    turn_left()
    turn_left()
    turn_left()

def hurdle():
    move()
    turn_left()
    move()
    turn_right()
    move()
    turn_right()
    move()
    turn_left()
    
#instead of calling hurdle() 6 times, make a FOR loop with RANGE
for step in range(6):
    hurdle()
