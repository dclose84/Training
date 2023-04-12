# Conditional / If Else
water_level = 50
if water_level > 80:
    print("Drain water")
else: 
    print("Continue ")
    
# > Greater than
# < Less than
# >= Greater than or equal to
# <= Less than or equal to
# == Equal to (1 = is an assignment, 2 == is a check equality)
# != Not equal to

print("Welcome to the rollercoaster!")
height = int(input("What is your height in cm? "))

if height >= 120:
  print("You can ride the rollercoaster!")
else:
  print("Sorry, you have to grow taller before you can ride.")

# modulo - It gives you the remainder after a division.
7 % 2 # = 1, 7/2 leaves a remainder of 1

# 3.1
# 🚨 Don't change the code below 👇
number = int(input("Which number do you want to check? "))
# 🚨 Don't change the code above 👆

#Write your code below this line 👇

modulo_number = number % 2
if modulo_number == 0:
    print("This is an even number.")
else:
    print("This is an odd number.")

#3.12
print("Welcome to the rollercoaster!")
height = int(input("What is your height in cm? "))

if height >= 120:
  print("You can ride the rollercoaster!")
  age = int(input("What is your age? "))
  if age < 12:
    print("Please pay $5.")  
  elif age <= 18:
    print("Please pay $7.")
  else:
    print("Please pay $12.")    
else:
  print("Sorry, you have to grow taller before you can ride.")
  
#3.2 BMI Calculator 2.0

# Under 18.5 they are underweight
# Over 18.5 but below 25 they have a normal weight
# Over 25 but below 30 they are slightly overweight
# Over 30 but below 35 they are obese
# Above 35 they are clinically obese.

# 🚨 Don't change the code below 👇
height = float(input("enter your height in m: "))
weight = float(input("enter your weight in kg: "))
# 🚨 Don't change the code above 👆

#Write your code below this line 👇
bmi = round(weight / height ** 2)

if bmi < 18.5:
  print(f"Your BMI is {bmi}, you are are underweight.")
elif bmi <= 25:
 print(f"Your BMI is {bmi}, you have a normal weight.")
elif bmi <= 30:
  print(f"Your BMI is {bmi}, you are slightly overweight.")
elif bmi <= 35:
  print(f"Your BMI is {bmi}, you are obese.")
else:
  print(f"Your BMI is {bmi}, you are clinically obese.")

# 3.3
# 🚨 Don't change the code below 👇
year = int(input("Which year do you want to check? "))
# 🚨 Don't change the code above 👆

#Write your code below this line 👇

if (year % 4) != 0:
  print("Not Leap year.")
elif (year % 100) != 0:
    print("Leap year.")
elif (year % 400) != 0:
    print("Not Leap year.")
else:
  print("Leap year.")
  
#suggested:
if year % 4 == 0:
  if year % 100 == 0:
    if year % 400 == 0:
      print("Leap Year.")
    else:
      print("Not Leap Year.")
  else:
    print("Leap Year.")
else:
  print("Not Leap Year.")

#34 Multiple If Statements in Succession, rollercoaster v2
print("Welcome to the rollercoaster!")
height = int(input("What is your height in cm? "))
bill = 0

if height >= 120:
  print("You can ride the rollercoaster!")
  age = int(input("What is your age? "))
  if age < 12:
    bill = 5
    print("Child tickets are $5.")  
  elif age <= 18:
    bill = 7
    print("Youth tickets are $7.")
  else:
    bill = 12
    print("Adult tickets are $12.")    

  wants_photo = input("Do you want a photo taken? Y or N. ")
  if wants_photo == "Y":
    #add $3 to their bill
    bill += 3
  print(f"Your final bill is ${bill}")

else:
  print("Sorry, you have to grow taller before you can ride.")
  
#3.4
# 🚨 Don't change the code below 👇
print("Welcome to Python Pizza Deliveries!")
size = input("What size pizza do you want? S, M, or L ")
add_pepperoni = input("Do you want pepperoni? Y or N ")
extra_cheese = input("Do you want extra cheese? Y or N ")
# 🚨 Don't change the code above 👆

#Write your code below this line 👇
# Small Pizza: $15
# Medium Pizza: $20
# Large Pizza: $25
# Pepperoni for Small Pizza: +$2
# Pepperoni for Medium or Large Pizza: +$3
# Extra cheese for any size pizza: + $1

bill = 0
if size == "S":
  bill += 15
  if add_pepperoni == "Y":
    bill +=2
  if extra_cheese == "Y":
    bill += 1
elif size == "M":
  bill += 20
  if add_pepperoni == "Y":
    bill += 3
  if extra_cheese == "Y":
    bill += 1
elif size == "L":
  bill += 25
  if add_pepperoni =="Y":
    bill += 3
  if extra_cheese == "Y":
    bill += 1
print(f"Your final bill is: ${bill}.")

#3.4 suggested
bill = 0
if size == "S":
  bill += 15
elif size == "M":
  bill += 20
else:
  bill += 25
  
if add_pepperoni == "Y":
  if size == "S":
    bill += 2
  else:
    bill += 3
    
if extra_cheese == "Y":
  bill += 1
print(f"Your final bill is: ${bill}.")

#36 logical operators
# and or not
# rollercoaster v3, midlife crisis (45-55 ride for free)
print("Welcome to the rollercoaster!")
height = int(input("What is your height in cm? "))
bill = 0

if height >= 120:
  print("You can ride the rollercoaster!")
  age = int(input("What is your age? "))
  if age < 12:
    bill = 5
    print("Child tickets are $5.")  
  elif age <= 18:
    bill = 7
    print("Youth tickets are $7.")
  elif age >= 45 and age <= 55:
    print("Midlife Crisis ride for free.")
  else:
    bill = 12
    print("Adult tickets are $12.")    

  wants_photo = input("Do you want a photo taken? Y or N. ")
  if wants_photo == "Y":
    #add $3 to their bill
    bill += 3
  print(f"Your final bill is ${bill}")

else:
  print("Sorry, you have to grow taller before you can ride.")
  
#37, 3.5 Love Calculator
# lower_case_Name = "Name".lower()
# lower_case_Name.count("a")

# 🚨 Don't change the code below 👇
print("Welcome to the Love Calculator!")
name1 = input("What is your name? \n")
name2 = input("What is their name? \n")
# 🚨 Don't change the code above 👆

#Write your code below this line 👇
# lower_case_Name = "Name".lower()
# lower_case_Name.count("a")

lower_Name1 = name1.lower()
lower_Name2 = name2.lower()

true_count = lower_Name1.count("t") + lower_Name1.count("r") + lower_Name1.count("u") + lower_Name1.count("e") + lower_Name2.count("t") + lower_Name2.count("r") + lower_Name2.count("u") + lower_Name2.count("e")
love_count = lower_Name1.count("l") + lower_Name1.count("o") + lower_Name1.count("v") + lower_Name1.count("e") + lower_Name2.count("l") + lower_Name2.count("o") + lower_Name2.count("v") + lower_Name2.count("e")

love_score = str(true_count) + str(love_count)
love_score_int = int(love_score)

if love_score_int < 10 or love_score_int > 90:
    print(f"Your score is {love_score_int}, you go together like coke and mentos.")
elif love_score_int >= 40 and love_score_int <= 50:
    print(f"Your score is {love_score_int}, you are alright together.")
else:
    print(f"Your score is {love_score_int}.")

#suggested:
combined_string = name1 + name2
lower_case_string = combined_string.lower()
t = lower_case_string.count("t")
r = lower_case_string.count("r")
u = lower_case_string.count("u")
e = lower_case_string.count("e")

true = t + r + u + e

l = lower_case_string.count("l")
o = lower_case_string.count("o")
v = lower_case_string.count("v")
e = lower_case_string.count("e")

love = l + o + v + e

love_score = int(str(true) + str(love))
if love_score < 10 or love_score > 90:
  print(f"Your score is {love_score}, you go together like coke and mentos.")
elif love_score >= 40 and love_score <= 50:
  print(f"You love score is {love_score}, you are alright together.")
else:
  print(f"Your love score is {love_score}")
  
#38 - Day 3 project, Treasure Island
