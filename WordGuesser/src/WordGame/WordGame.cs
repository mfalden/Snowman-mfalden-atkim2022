namespace WordGuesser
{
    using System;
    using System.Collections.Generic;

    public class WordGame : IWordGame
    {
        // marielle

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

            // TODO: Initialize member variables
            this.fullWord = wordToGuess.ToUpper();
            this.guessLimit = guessLimit;
            this.incorrectGuesses = 0;
            this.guesses = new List<char>();
        }

        public string CheckGuess(string guess)
        {
            throw new System.NotImplementedException();
        }
    
        // austin DID

        public int CountLetter(char guess)
        {
            int count;
            count = 0; 
            if (char.IsLetter(guess) == false)
            {
                throw new ArgumentException("Invalid character:{guess}.");
            }
            else
            {
                char.ToUpper(guess);
                foreach (char c in this.fullWord)
                {
                    if (c == guess)
                    {
                        count++;
                    }
                }
            }
            return count; 
        }
        
        // austin DID
        public string GetFullWord()
        {
            return this.fullWord;
        }
        // marielle
        public string GetGuessedLetters()
        {
            throw new System.NotImplementedException();
        }
        //austin DID
        public int GetGuessLimit()
        {
            return this.guessLimit;
        }

        // marielle
        public int GetIncorrectGuesses()
        {
            throw new System.NotImplementedException();
        }
        // austin  DID
        /// <summary>
        /// 
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

        // austin DID 
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