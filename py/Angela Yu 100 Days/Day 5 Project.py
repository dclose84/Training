#Day 5.1, Python Loops
fruits = ["Apple", "Peach", "Pear"]
for fruit in fruits:
    print(fruit + " Pie")
print(fruits)

#5.1 Average Height (without using sum)
# 🚨 Don't change the code below 👇
student_heights = input("Input a list of student heights ").split()
for n in range(0, len(student_heights)):
  student_heights[n] = int(student_heights[n])
# 🚨 Don't change the code above 👆


#Write your code below this row 👇
# total_height = sum(student_heights)
# number_of_students = len(student_heights)
# average_height = round(total_height / number_of_students)
# print(average_height)

total_height = 0
for height in student_heights:
    total_height += height

number_of_students = 0
for student in student_heights:
    number_of_students += 1

average_height = total_height / number_of_students
print(round(average_height))

#5.2 High Score (without using min/max)
# 🚨 Don't change the code below 👇
student_scores = input("Input a list of student scores ").split()
for n in range(0, len(student_scores)):
  student_scores[n] = int(student_scores[n])
print(student_scores)
# 🚨 Don't change the code above 👆

#Write your code below this row 👇
# easy way if we are not hand-cuffed
#print(max(student_scores))

max_Score = 0
for score in student_scores:
    if score > max_Score:
        max_Score = score
print(f"The highest score in the class is: {max_Score}")

#53, for loops and range() function
#1 to 100
total = 0
for number in range(1, 101):
    total += number
print(total)

#54 (5.3), Adding Even Numbers
# total = 0
# for number in range(1, 101):
#     total += number
# print(total)

#Write your code below this row 👇
total_even = 0
for number in range(2,101,2):
    total_even += number
print (total_even)

# or with if and modulo
total_even2 = 0
for number in range(1,101):
    if number % 2 == 0:
        total_even2 += number
print(total_even2)

#55 (5.4) The FizzBuzz Job Interview Question
fb = 0
for number in range (1,101):
    fb += 1
    if number % 15 == 0:
        print("FizzBuzz")
    elif number % 5 == 0:
        print("Buzz")
    elif number % 3 == 0:
        print("Fizz")
    else:
        print(fb)

#suggested:        
for number in range(1,101):
    if number % 3 == 0 and number % 5 == 0:
         print("FizzBuzz")
    elif number % 5 == 0:
        print("Buzz")
    elif number % 3 == 0:
        print("Fizz")
    else:
        print(number)

#56 (5.5) Final Project, PyPassword Generator
import random
letters = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z']
numbers = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9']
symbols = ['!', '#', '$', '%', '&', '(', ')', '*', '+']

print("Welcome to the PyPassword Generator!")
nr_letters = int(input("How many letters would you like in your password?\n")) 
nr_symbols = int(input(f"How many symbols would you like?\n"))
nr_numbers = int(input(f"How many numbers would you like?\n"))

#Eazy Level - Order not randomised:
#e.g. 4 letter, 2 symbol, 2 number = JduE&!91

password = ""

for lets in range(1, nr_letters + 1):
  random_char = random.choice(letters)
  password += random_char

# more efficient is
# for char in range(1, nr_letters + 1):
#   password += random.choice(letters)

for syms in range(1, nr_symbols + 1):
  random_syms = random.choice(symbols)
  password += random_syms

for nums in range(1, nr_numbers + 1):
  random_nums = random.choice(numbers)
  password += random_nums

print(password)

#Hard Level - Order of characters randomised:
#e.g. 4 letter, 2 symbol, 2 number = g^2jk8&P
password_list = []

for char in range(1, nr_letters + 1):
  password_list.append(random.choice(letters))

for syms in range(1, nr_symbols + 1):
  password_list.append(random.choice(symbols))
  
for nums in range(1, nr_numbers + 1):
  password_list.append(random.choice(numbers))

random.shuffle(password_list)

password = ""
for char in password_list:
  password += char
print(password)

