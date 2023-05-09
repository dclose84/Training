# Day 7 (68) - How to break a complex problem down into a flow chart
#Step 1 
import random
word_list = ["aardvark", "baboon", "camel"]

#TODO-1 - Randomly choose a word from the word_list and assign it to a variable called chosen_word.

chosen_word = random.choice(word_list)
print(chosen_word)

#TODO-2 - Ask the user to guess a letter and assign their answer to a variable called guess. Make guess lowercase.

guess = input("Guess a letter: \n").lower()
#print(guess)

#TODO-3 - Check if the letter the user guessed (guess) is one of the letters in the chosen_word.
if guess in chosen_word:
    print("You guessed a letter in the word!")
else:
    print("Sorry, the letter you guessed is not in the word.")