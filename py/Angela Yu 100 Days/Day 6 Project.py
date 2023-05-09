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

#62 While Loops
# While robot is plugged into wall, move forward
# For item in list_of_items: Do something to each Item
# For number in range(a,b): print(number)

while something_is_true:
    Do something repeatedly
    
number_of_hurdles = 6
while number_of_hurdles >0:
    jump()
    number_of_hurdles -= 1
    
while not at_goal():
    hurdle()
    
#or 
while at_goal() != True:
    hurdle()
    
# For loops are often better for multiple prints, while loops work better when not having to perform multiple prints
# For loops have a determined number of iterations, while is logic based on unknown iterations
# While loops can be infinite and is an issue (infinite loops)

#63 While loops advanced
def turn_right():
    turn_left()
    turn_left()
    turn_left()

def scale():
    turn_left()
    move()
    turn_right()
    move()
    turn_right()
    move()
    turn_left()

while at_goal() != True:
    if front_is_clear() == True:
        move()
    elif wall_in_front() == True:
        scale()
        
#64 Hurdles Challenge using While Loops
def turn_right():
    turn_left()
    turn_left()
    turn_left()

def scale():
    turn_right()
    move()

while at_goal() != True:
    if wall_in_front() == True:
        if right_is_clear() == True:
            scale()
        else:
            turn_left()
    elif wall_on_right() == True:
        move()
    elif front_is_clear() == True:
        if right_is_clear() == True:
            scale()
        else:
            move()

#suggested
def turn_right():
    turn_left()
    turn_left()
    turn_left()

def jump():
    turn_left()
    while wall_on_right():
        move()
    turn_right()
    move()
    turn_right()
    while front_is_clear():
        move()
    turn_left()

while at_goal() != True:
    if wall_in_front():
        jump()
    else:
        move()

#65 Final Project: Escaping the Maze
def turn_right():
    turn_left()
    turn_left()
    turn_left()
    
while at_goal() != True:
    if front_is_clear():
        move()
    elif wall_in_front():
        if right_is_clear():
            turn_right()
        else:
            turn_left()
    else:
        turn_left()