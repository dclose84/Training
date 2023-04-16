#4.3 Treasure Map
# 🚨 Don't change the code below 👇
row1 = ["⬜️","️⬜️","️⬜️"]
row2 = ["⬜️","⬜️","️⬜️"]
row3 = ["⬜️️","⬜️️","⬜️️"]
map = [row1, row2, row3]
print(f"{row1}\n{row2}\n{row3}")
position = input("Where do you want to put the treasure? ")
# 🚨 Don't change the code above 👆

#Write your code below this row 👇
verY = int(position[1])
horX = int(position[0])
map[verY-1][horX-1] = 'X'
#Write your code above this row 👆

# 🚨 Don't change the code below 👇
print(f"{row1}\n{row2}\n{row3}")