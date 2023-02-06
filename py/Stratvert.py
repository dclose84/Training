# Kevin Stratvert Python for Beginners Tutorial (https://youtu.be/b093aqAZiPU)

# == Equal to 2==2 True
# != Not equal to 4!=4 Fale
# < Less than 3<5 True
# > Greater than 3>5 False
# >= Greater than or equal to 2>=3 False
# <= Less than or equal to 3<=5 True


red_Bucket = "Devin"
del red_Bucket
best_Bucket = "Devin Close"
print(type(best_Bucket)) # class 'str'
print(best_Bucket)

red_Bucket = input("What do you want to put in the bucket? ")
print (red_Bucket) 

print(5==4) #false

# is child age for Kindergarten?
Child_Age = 3
Age_at_Kindergarten = 5

# First section (False)
print(Childs_Age == Age_at_Kindergarten)

# Second section (if, elif, else statements)
if Child_Age < Age_at_Kindergarten:
    print("Child should be in pre-school")
elif Child_Age == Age_at_Kindergarten:
    print("Enjoy Kindergarten")
else: 
    print(("Child should be in another class"))

# Third section (functions)
print("Devin Close is the best!")
print("Devin Close is the best!")
print("Devin Close is the best!")

def print_Devin():
    text = "Devin Close is the best!"
    print(text)
    print(text)
    print(text) 
print_Devin()

def print_Devin(text):
    print(text)
    print(text)
    print(text)
print_Devin("Devin Close is the best!")

def school_age_calculator(age,name):
    if age < 5:
        print("Enjoy the time!", name, "is only", age)
    elif age == 5:
        print("Enjoy Kindergarten,", name)
    else:
        print("They grow up so fast!")        
school_age_calculator(4,"Jean Gerard")

def add_ten_to_age(age):
    new_age = age + 10
    return new_age

How_Old_Will_I_Be + add_ten_to_age(3)
print(How_Old_Will_I_Be)

# Fourth section (while, for loops)
# while
x=0
while (x<5):
    print(x)
    x=x+1
    
# for
for x in range(5,10):
    print(x)
    
days=["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"]
for d in days:
    if(d=="Thu"):break
    # if(d=="Thu"):continue 
    print(d)
    
# Fifth section (import libraries)
import math
print("pi is", math.pi)

# Sixth section (troubleshooting)
print(helloworld) # read terminal error
print(10/0) # impossible

name = 'devin'
print("hello name")
