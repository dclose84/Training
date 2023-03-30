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

# 2.1
# 🚨 Don't change the code below 👇
two_digit_number = input("Type a two digit number: ")
# 🚨 Don't change the code above 👆

####################################
#Write your code below this line 👇
print(int(two_digit_number[0]) + int(two_digit_number[1]))
# suggested, 
# first_digit = int(two_digit_number[0])
# second_digit = int(two_digit_number[1])
# final_number = second_digit + first_digit
# print(two_digit_number)
