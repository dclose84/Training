# Day 4, random. offset, appending items to lists, indexerrors, working with nested lists
# Randomisation vs deterministic (mersenne twister is the python pseudo-random number generation)
import random

random_integer = random.randint(1,10)
print(random_integer)

# 0.000000 - 0.999999 ...
random_float = random.random()
print(random_float)

# this will give you from 0.00000... - 4.999999...
random_float * 5

love_score = random.randint(1,100)
print(f"Your love score is {love_score}")

# 4.1, heads or tails
# You are going to write a virtual coin toss program. It will randomly tell the user "Heads" or "Tails".

# Important, the first letter should be capitalised and spelt exactly like in the example e.g. Heads, not heads.

# There are many ways of doing this. But to practice what we learnt in the last lesson, you should generate a random number, either 0 or 1. Then use that number to print out Heads or Tails.

# e.g. 1 means Heads 0 means Tails
import random

random_integer = random.randint(0,1)
if random_integer == 0:
    print("Tails")
else:
    print("Heads")
    
#43 Understanding the offset and appending items to lists
#lists = [1, 2]
#fruits = [item1, item2]

states_of_america = ["Washington", "California", "Oregon"]
# below will print the first value in the list (0 is first)
print(states_of_america[0])

# below will print the last value in the list (-1 is last)
print(states_of_america[-1])

# below will change the value held in the index
states_of_america[1] = "Californication"

# below will append/add to the end of the list
states_of_america.append("Closelandia")

# other list commands are: extend (this add's multiple at a time) and many more

# if given a long CST, still will turn it into a list
str_inp = "Hello,from,AskPython"
op = str_inp.split(", ")
print (op)
# output = ['Hello', 'from', 'AskPython']

#4.2 Banker Roulette
# Import the random module here

# Split string method
names_string = input("Give me everybody's names, separated by a comma. ")
names = names_string.split(", ")
# 🚨 Don't change the code above 👆

#Write your code below this line 👇
import random
count_names = len(names)
# remember lists start at 0, so the count needs to be reduced by 1
random_name = random.randint(0,count_names - 1)
loser = names[random_name]

print(f"{loser} is going to buy the meal today!")

# secret weapon is using 
#loser = random.choice(names)

#45 IndexErrors and working with Nested Lists
#dirty_dozen = ["Strawberries", "Spinach", "Kale", "Nectarines", "Apples", "Grapes", "Peaches", "Cherries", "Pears", "Tomatoes", "Celery", "Potatoes"]

fruits = ["Strawberries", "Nectarines", "Apples", "Grapes", "Peaches", "Cherries", "Pears"]
vegetables = ["Spinach", "Kale", "Tomatoes", "Celery", "Potatoes"]

dirty_dozen = [fruits, vegetables]
 
print(dirty_dozen[1][1])
print(dirty_dozen[1][2])
print(dirty_dozen[1][3])

#4.3 Treasure Map
#omg this was a mind-wrecker. Was very confused until it clicked
# 🚨 Don't change the code below 👇
row1 = ["⬜️","️⬜️","️⬜️"]
row2 = ["⬜️","⬜️","️⬜️"]
row3 = ["⬜️️","⬜️️","⬜️️"]
map = [row1, row2, row3]
print(f"{row1}\n{row2}\n{row3}")
position = input("Where do you want to put the treasure? ")
# 🚨 Don't change the code above 👆

#Write your code below this row 👇
verY = int(position[1])
horX = int(position[0])
map[verY-1][horX-1] = 'X'
#Write your code above this row 👆

# 🚨 Don't change the code below 👇
print(f"{row1}\n{row2}\n{row3}")

# alternatively, though less succint
selected_row = map[verY - 1]
selected_row[horX - 1] = "X"

#4.4 Rock Paper Scissors
