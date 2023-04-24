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