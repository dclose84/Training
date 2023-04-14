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
