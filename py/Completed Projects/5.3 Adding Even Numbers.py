#54 (5.3), Adding Even Numbers
#Write your code below this row 👇
total_even = 0
for number in range(2,101,2):
    total_even += number
print (total_even)

# or with if and modulo
# total_even2 = 0
# for number in range(1,101):
#     if number % 2 == 0:
#         total_even2 += number
# print(total_even2)