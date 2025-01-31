# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

This program's purpose is to create an entertaining guessing game for a player.

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

Not applicable for this project.

### 3a iii.

Describes the input and output of the program demonstrated in the video.

Not applicable for this project

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
 this.guesses.Add(guess[0]);
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
foreach (char c in this.guesses)
            {
                letters += $" {c}";
            }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable {guesses}

### 3b iv.

Describes what the data contained in the list represents in your program

The list stores all of the player's previous valid guesses.  

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

Without a list, I would need 26  variables to track the guesses a player made. For example I would need a variable to track 26 possible incorrect guesses for a guessing game with a range from A-Z in the alphabet. This many variables would not be very useful or efficient. To account for duplicate guesses, you would need almost an infinite amount of variables. So without a list, it would be difficult to print out all of the players guesses. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
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
                guess = char.ToUpper(guess);
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
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
else
            {
                int count;
                count = this.CountLetter(guess[0]);
                this.guesses.Add(guess[0]);
                if (count == 1)
                {
                    return $"There is 1 {guess}";
                }
                else
                {
                    return $"There are {count} {guess}s";
                }
            }
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

CountLetter counts the amount of times a guessed letter appears in the word to guess. In the program, the CountLetter procedure is used to present the amount of times a guessed letter appears in a word to the player.

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

First, it selects if the player's guess is a letter. If that is false, then it prints out a message saying the guess is invalid. If the guess was a letter, then it will iterate through a loop; for every time the character appears in the word to be guessed, the count will increase by 1.

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

Using char guess, if someone guesses a "!" for target word "apple"

Second call:

Using char guess, if someone guesses a "p" for target word "apple"

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
If "!" is a valid letter in the english alphabet. If valid, will move on to count the amount of times "!" appears in the word "apple"

Condition(s) tested by the second call:

If "p" is a valid letter in the english alphabet. If valid, will move on to count the amount of times "p" appears in the word "apple"

### 3d iii.

Result of the first call:

Because ! is not a valid letter, this prints "Invalid character: {guess}." 

Result of the second call:

This will result in a count of 2 since 'p' appears in 'apple' 2 times.  
