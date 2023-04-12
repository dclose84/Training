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