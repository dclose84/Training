# This is a comment
# == Equal to 2==2 True
# != Not equal to 4!=4 Fale
# < Less than 3<5 True
# > Greater than 3>5 False
# >= Greater than or equal to 2>=3 False
# <= Less than or equal to 3<=5 True
# ctl+/ will comment a line

# input() will get user input in console
# Then print() will print the word "Hello" and the user input
print("Hello " + input("What is your name?"))

#1.3
# After inputting your name, it will print the number of characters in the string that is your name
name = input("What is your name?")
print(len(name))

# Video suggested way to accomplish this is: print( len ( input("What is your name?") ) )

#1.4
# 🚨 Don't change the code below 👇
a = input("a: ")
b = input("b: ")
# 🚨 Don't change the code above 👆

####################################
#Write your code below this line 👇

c = a
d = b
a = d
b = c

# Video suggested way to accomplish this is: c = a, a = b, b = c

#Write your code above this line 👆
####################################

# 🚨 Don't change the code below 👇
print("a: " + a)
print("b: " + b)
