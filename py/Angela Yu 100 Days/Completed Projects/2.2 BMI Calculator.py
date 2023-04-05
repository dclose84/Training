#2.2 BMI Calculator
height = input("enter your height in m: ")
weight = input("enter your weight in kg: ")

height = float(height)
weight = float(weight)
bmi = (weight / (height ** 2))
bmi_as_int = int(bmi)
print(bmi_as_int)