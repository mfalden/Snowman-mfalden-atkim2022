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

        public string CheckGuess(string guess)
        {
            throw new System.NotImplementedException();
        }
    
        /// <summary>
        /// Counts how many times a letter appears in the word to guess.
        /// </summary>
        /// <param name="guess"></param>
        /// <returns></returns>
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
        
        /// <summary>
        /// Retrieves full word to guess.
        /// </summary>
        /// <returns></returns>
        public string GetFullWord()
        {
            return this.fullWord;
        }

        // marielle
        public string GetGuessedLetters()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Retrieves the limit of how many times a player can guess.
        /// </summary>
        /// <returns></returns>
        public int GetGuessLimit()
        {
            return this.guessLimit;
        }

        // marielle
        public int GetIncorrectGuesses()
        {
            throw new System.NotImplementedException();
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
        public bool IsGameOver()
        {
            throw new System.NotImplementedException();
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