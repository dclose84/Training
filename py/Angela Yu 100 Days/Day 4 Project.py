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
