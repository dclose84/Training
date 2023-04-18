#4.4 Rock Paper Scissors
import random
rock = '''
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
'''
paper = '''
    _______
---'   ____)____
          ______)
          _______)
         _______)
---.__________)
'''
scissors = '''
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
'''

choice = [rock, paper, scissors]
print("Welcome to the Rock Paper Scissors World Championships!")
user_entry = int(input("What do you choose? Type 0 for Rock, 1 for Paper or 2 for Scissors.\n"))
if user_entry >= 3 or user_entry < 0:
    print("You typed an invalid number, you lose!")
else:
  print(choice[user_entry])
    
  print("Computer chose:")
  computer_random = random.randint(0,2)

  print(choice[computer_random])


  if user_entry == computer_random:
    print("You tie.")
  elif user_entry == 0 and computer_random == 2:
    print("You win.")
  elif user_entry == 1 and computer_random == 0:
    print("You win.")
  elif user_entry == 2 and computer_random == 1:
    print("You win.")
  else:
    print("You lose.")