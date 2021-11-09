namespace WordGuesser
{
    using System;
    using System.Collections.Generic;

    public class WordGame : IWordGame
    {
// marielle

        private string fullWord;
        private List<char> lettersGuessed;
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
            this.fullWord = wordToGuess;
            this.guessLimit = guessLimit;
            this.incorrectGuesses = 0;
            this.lettersGuessed = new List<char>();
        }

            public string CheckGuess(string guess)
        {
            throw new System.NotImplementedException();
        }
// austin 
        public int CountLetter(char guess)
        {
            throw new System.NotImplementedException();
        }
// austin 
        public string GetFullWord()
        {
            throw new System.NotImplementedException();
        }
// marielle
        public string GetGuessedLetters()
        {
            throw new System.NotImplementedException();
        }
//austin 
        public int GetGuessLimit()
        {
            throw new System.NotImplementedException();
        }
// marielle
        public int GetIncorrectGuesses()
        {
            throw new System.NotImplementedException();
        }
// austin 
        public string GetWord()
        {
            throw new System.NotImplementedException();
        }
// marielle
        public bool IsGameOver()
        {
            throw new System.NotImplementedException();
        }

        // austin
        public bool IsGameWon()
        {
            throw new System.NotImplementedException();
        }
    }

}