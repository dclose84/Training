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