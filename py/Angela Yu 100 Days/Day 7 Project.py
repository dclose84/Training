# Day 7 (68) - How to break a complex problem down into a flow chart
#Step 1 
import random
word_list = ["aardvark", "baboon", "camel"]

#TODO-1 - Randomly choose a word from the word_list and assign it to a variable called chosen_word.

chosen_word = random.choice(word_list)
print(chosen_word)

#TODO-2 - Ask the user to guess a letter and assign their answer to a variable called guess. Make guess lowercase.

guess = input("Guess a letter: ").lower()
#print(guess)

#TODO-3 - Check if the letter the user guessed (guess) is one of the letters in the chosen_word.
if guess in chosen_word:
    print("You guessed a letter in the word!")
else:
    print("Sorry, the letter you guessed is not in the word.")

#suggested
for letter in chosen_word:
  if letter == guess:
    print("Correct")
  else:
    print("Incorrect")
    
#72 - Replacing blanks with guesses
#Step 2

import random
word_list = ["aardvark", "baboon", "camel"]
chosen_word = random.choice(word_list)

#Testing code
print(f'Pssst, the solution is {chosen_word}.')

#TODO-1: - Create an empty List called display.
#For each letter in the chosen_word, add a "_" to 'display'.
#So if the chosen_word was "apple", display should be ["_", "_", "_", "_", "_"] with 5 "_" representing each letter to guess.

# display = list(chosen_word)
# listed_word = list(chosen_word)

# for letter in range(len(display)):
#   display[letter] = "_"

#suggested
display = []
word_length = len(chosen_word)
for _ in range(word_length):
  display += "_"

print(display)
guess = input("Guess a letter: ").lower()

#TODO-2: - Loop through each position in the chosen_word;
#If the letter at that position matches 'guess' then reveal that letter in the display at that position.
#e.g. If the user guessed "p" and the chosen word was "apple", then display should be ["_", "p", "p", "_", "_"].
# got stuck here :(
for position in range(word_length):
  letter = chosen_word[position]  
  if letter == guess:
    display[position] = letter

#TODO-3: - Print 'display' and you should see the guessed letter in the correct position and every other letter replace with "_".
#Hint - Don't worry about getting the user to guess the next letter. We'll tackle that in step 3.
print(display)

#73/74, Challenge 3 - Checking if the player has won
#Step 3

import random
word_list = ["aardvark", "baboon", "camel"]
chosen_word = random.choice(word_list)
word_length = len(chosen_word)

#Testing code
print(f'Pssst, the solution is {chosen_word}.')

#Create blanks
display = []
for _ in range(word_length):
    display += "_"

#TODO-1: - Use a while loop to let the user guess again. The loop should only stop once the user has guessed all the letters in the chosen_word and 'display' has no more blanks ("_"). Then you can tell the user they've won.

end_of_game = False

while not end_of_game:
  guess = input("Guess a letter: ").lower()
  
  #Check guessed letter
  for position in range(word_length):
    letter = chosen_word[position]
    #print(f"Current position: {position}\n Current letter: {letter}\n Guessed letter: {guess}")
    if letter == guess:
        display[position] = letter
  
  print(display)
  if "_" not in display:
    end_of_game = True
    print("You win!")
    
#75/76 - Challenge 4 - Keeping track of the player's lives
