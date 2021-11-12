namespace WordGuesser
{
    using System;
    using System.Collections.Generic;

    public class WordGame : IWordGame
    {

        private string fullWord;
        private List<char> guesses;
        private int incorrectGuesses;
        private int guessLimit;

        public WordGame(string wordToGuess, int guessLimit)
        {
            if (guessLimit <= 0)
            {
                throw new ArgumentException($"Illegal guessLimit '{guessLimit}'. The guess limit must be greater than 0.");
            }

            foreach (char c in wordToGuess)
            {
                if (char.IsLetter(c) == false)
                {
                    throw new ArgumentException($"Illegal word '{wordToGuess}'. The word must contain only letters.");
                }
            }

            this.fullWord = wordToGuess.ToUpper();
            this.guessLimit = guessLimit;
            this.incorrectGuesses = 0;
            this.guesses = new List<char>();
        }


// marielle

        /// <summary>
        /// Checks a users guess and returns a string message informing them of the result and updating the game state as necessary.<br/>
        /// 1. The guess is sanitized such that the case, preceding, and trailing white space are ignored.<br/>
        /// 2. If the length of the sanitized input is not 1 character, returns "You must guess a single letter".<br/>
        /// 3. If the character is not a letter, returns "You can only guess letters"<br/>
        /// 4. If the letter guessed has been previously guessed, returns "You've already guessed {guess}"<br/>
        /// 5. If the letter has not been previously guessed, it is added to the list of guessed letters.
        /// 6. If the letter is not part of the word to be guessed, the number of incorrect guesses increments by 1 and then returns "Ouch! No {guess}s"<br/>
        /// 7. If the guessed letter appears in the word once, returns "There is 1 {guess}".<br/>
        /// 8. If the letter is correct and appears multiple times, returns "There are {count} {guess}s".<br/>
        /// </summary>
        /// <param name="guess">The player's guess.</param>
        /// <returns>A message informing them of the result.</returns>
        public string CheckGuess(string guess)
        {
            guess = guess.Trim().ToUpper();
            if (guess.Length != 1)
            {
                return "You must guess a single letter";
            }
            else if (char.IsLetter(guess[0]) == false)
            {
                return "You can only guess letters";
            }
            else if (this.guesses.Contains(guess[0]))
            {
                return $"You've already guessed {guess}";
            }
            else if (this.fullWord.Contains(guess) == false)
            {
                this.incorrectGuesses++;
                this.guesses.Add(guess[0]);
                return $"Ouch! No {guess}s";
            }
            else
            {
                int count;
                count = this.CountLetter(guess[0]);
                if (count == 1)
                {
                    return $"There is 1 {guess}";
                }
                else
                {
                    return $"There are {count} {guess}s";
                }
            }
        }
    
        /// <summary>
        /// Counts how many times a letter appears in the word to guess.
        /// </summary>
        /// <param name="guess"></param>
        /// <returns></returns>

        // austin 
        public int CountLetter(char guess)
        {
            if (char.IsLetter(guess) == false)
            {
                throw new ArgumentException($"Invalid character:{guess}.");
            }
            else
            {
                int count;
                count = 0;
                char.ToUpper(guess);
                foreach (char c in this.fullWord)
                {
                    if (c == guess)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

// in class 

        /// <summary>
        /// Returns the word that is to be guessed without any missing letters.
        /// </summary>
        /// <returns>The word that is being guessed.</returns>
        public string GetFullWord()
        {
            return this.fullWord;
        }

// marielle

        /// <summary>
        /// Returns a string containing each letter that has been guessed in the order that they were guessed.
        /// </summary>
        /// <returns>A string containing each letter that has been guessed.</returns>
        public string GetGuessedLetters()
        {
            string letters;
            letters = string.Empty;
            foreach (char c in this.guesses)
            {
                letters += $"{c} ";
            }

            return letters.Trim();
        }

// in class

        /// <summary>
        /// Returns the guess limit.
        /// </summary>
        /// <returns>The guess limit.</returns>
        public int GetGuessLimit()
        {
            return this.guessLimit;
        }

// marielle

        /// <summary>
        /// Returns the guess limit.
        /// </summary>
        /// <returns>The guess limit.</returns>
        public int GetIncorrectGuesses()
        {
            return this.incorrectGuesses;
        }

        /// <summary>
        /// Returns the word to be guessed with the unguessed letters as underscores.
        /// </summary>
        /// <returns></returns>
        public string GetWord()
        {
            string word;
            word = string.Empty;

            foreach (char c in this.fullWord)
            {
                if (this.guesses.Contains(c))
                {
                    word += $"{c} ";
                }
                else 
                {
                    word += "_ ";
                }
            }
            return word.Trim();
        }

// marielle

        /// <summary>
        /// Returns the number of incorrect guesses.
        /// </summary>
        /// <returns>The number of incorrect guesses.</returns>
        public bool IsGameOver()
        {
            return this.incorrectGuesses >= this.guessLimit;
        }

        /// <summary>
        /// Checks if the player has won the game and guessed the full word. 
        /// </summary>
        /// <returns></returns>
        public bool IsGameWon()
        {
            foreach (char c in this.fullWord)
            {
                if (this.guesses.Contains(c))
                {
                    return true;
                }
            }
            return false;
        }
    }

}