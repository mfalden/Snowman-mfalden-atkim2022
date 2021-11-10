namespace WordGuesser
{
    using System.Collections.Generic;


    public class WordGame : IWordGame
    {
        int guess;
        int IncorrectGuesses;
        int guessLimit;
        private List<int> lettersGuessed;
        private string wordToGuess;

        // marielle please help me
        /// <summary>
        /// Checks a users guess and returns a string message informing them of the result and updating the game state as necessary.
        /// </summary>
        /// <param name="guess">The player's guess.</param>
        /// <returns>The number of times the player's guess appears in the word, if it does.</returns>
        public string CheckGuess(string guess)
        {
            guess = guess.Trim().ToUpper();
            if (guess.Length != 1)
            {
                return "You must guess a single letter.";
            }
            else if (char.IsLetter(guess[0]) == false)
            {
                return "You can only guess letters.";
            }
            else if (this.lettersGuessed.Contains(guess[0]))
            {
                return $"You've already guessed {guess}.";
            }
            else if (this.wordToGuess.Contains(guess) == false)
            {
                this.IncorrectGuesses++;
                this.lettersGuessed.Add(guess[0]);
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
            return this.IncorrectGuesses;
        }
// austin 
        public string GetWord()
        {
            throw new System.NotImplementedException();
        }
// marielle
/// <summary>
/// waaaa
/// </summary>
/// <returns></returns>
        public bool IsGameOver()
        {
            return this.IncorrectGuesses >= this.guessLimit;
        }

        // austin
        public bool IsGameWon()
        {
            throw new System.NotImplementedException();
        }
    }

}