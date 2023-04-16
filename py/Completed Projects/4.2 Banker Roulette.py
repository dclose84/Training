#4.2 Banker Roulette
# Import the random module here
import random
# Split string method
names_string = input("Give me everybody's names, separated by a comma. ")
names = names_string.split(", ")
# 🚨 Don't change the code above 👆

#Write your code below this line 👇
count_names = len(names)
random_name = random.randint(0,count_names - 1)
loser = names[random_name]

# secret weapon is using 
#loser = random.choice(names)

print(f"{loser} is going to buy the meal today!")

