#2.4 tip calculator
print("Welcome to the tip calculator")
bill = float(input("What was the total bill? $"))
tip = int(input("What percentage would you like to give? 10, 12 or 15? "))
people = int(input("How many people to split the bill? "))
tip_as_percent = tip / 100
total_tip_amount = bill * tip_as_percent
total_bill = bill + total_tip_amount
bill_per_person = total_bill / people
final_amount = round(bill_per_person, 2)
#this gets tricky, since by default it is only printing 1 decimal, this will force the format to two decimals even if the answer doesn't contain 2 decimals
final_amount = "{:.2f}".format(bill_per_person)
print(f"Each person should pay ${final_amount}")