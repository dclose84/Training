#Data Types

#String "", [] subscript -> will index/position , 0 = first letter in the string. Below will print the H in Hello
print("Hello"[4])

# this will not show as a number, but as a string, ie. 123345
print("123" + "345")

#Integer are numbers, _ are equivalent to commas separating numbers, will print without them
print(123 + 345)
print(123_456_789)

#Float , decimal numbers
3.14159

#Boolean, true or false
True
False

#typeerrors, can't put a rock through a fry machine, 
# num_char = len(input("What is your name?"))
# new_num_char = str(num_char)
# #print("Your name has" + num_char + "characters."))
# #print(type(num_char))
# print("Your name has" + new_num_char + "characters."))
a = str(123)
print(type(a))

#mathematical
3 + 5
7 - 4
3 * 2
#division will print as float (6 / 3 = 2.0)
6 / 3
# exponents, 2 to the power of 2
2 ** 2 

# PEMDAS
# () Parentheses
# ** Exponents
# * Multiplication
# / Division
# + Addition
# - Subtraction

#2.2
# 🚨 Don't change the code below 👇
height = input("enter your height in m: ")
weight = input("enter your weight in kg: ")
# 🚨 Don't change the code above 👆

#Write your code below this line 👇
height = float(height)
weight = float(weight)
bmi = (weight / (height ** 2))
bmi_as_int = int(bmi)
print(bmi_as_int)

# to round, use round function
print(round(8/3))

# floor division
print(8 // 3)

score = 0
# user scores a goal
score += 1
print(score)

# f-strings
score = 0

# for mixing types in a concat
print("your score is " + str(score))

score = 0
height = 1.8
isWinning = True
#instead can f-string 
print(f"your score is {score}, your height is {height}, you are winning is {isWinning}")

#2.3
# 🚨 Don't change the code below 👇
age = input("What is your current age? ")
# 🚨 Don't change the code above 👆

#Write your code below this line 👇

x = (90*365) - (int(age) * 365)
y = (90*52) - (int(age) * 52)
z = (90*12) - (int(age) * 12)

print(f"You have {x} days, {y}  weeks, and {z} months left")

#suggested
age_as_int = int(age)

years_remaining = 90 - age_as_int
days_remaining = years_remaining * 365
weeks_remaining = years_remaining * 52
months_remaining = years_remaining * 12

print(f"You have {days_remaining} days, {weeks_remaining} weeks, {months_remaining} months left")

