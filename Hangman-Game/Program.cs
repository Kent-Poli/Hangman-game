using Hangman_Game;
using System;

Console.WriteLine("Välkommen till Hänga gubbe!");
Console.WriteLine("Gissa på en frukt!");

string secretWord = Methods.Random(); 
char[] displayWordLength = Methods.InitializeDisplayWord(secretWord);
int attemptsLeft = 10;
bool wordGuessed = false;

while (attemptsLeft > 0 && !wordGuessed)
{
    Console.WriteLine("\nHemligt ord: " + string.Join(" ", displayWordLength));
    Console.WriteLine("Försök kvar: " + attemptsLeft);
    Console.WriteLine("Vill du gissa hela ordet eller en bokstav?");
    string guess = Console.ReadLine().Trim().ToLower();  

    if (guess.Length == 0)
    {
        Console.WriteLine("Ogiltig gissning. Ange antingen en bokstav eller ett ord.");
        continue; 
    }

    if (guess.Length == 1)
    {
        char guessedChar = guess[0];
        Console.WriteLine($"Du gissade på bokstaven {guessedChar}");
        bool correctGuess = false;

        for (int i = 0; i < secretWord.Length; i++)
        {
            if (secretWord[i] == guessedChar)
            {
                displayWordLength[i] = guessedChar;
                correctGuess = true;
            }
        }

        if (!correctGuess)
        {
            Console.WriteLine($"Bokstaven {guessedChar} finns inte i ordet.");
            attemptsLeft--;
        }
    }
    else
    {
        Console.WriteLine($"Du gissade på ordet {guess}");
        if (guess == secretWord)
        {
            Console.WriteLine($"Grattis! Du gissade rätt! Hemliga ordet är {secretWord}");
            break;
        }
        else
        {
            Console.WriteLine($"Ops! Fel gissning!");
            attemptsLeft--;
        }
    }


    if (new string(displayWordLength) == secretWord)
    {
        Console.WriteLine($"Grattis! Du gissade rätt! Hemliga ordet är {secretWord}");
        wordGuessed = true;
    }
}

Console.WriteLine($"Det hemliga ordet var: {secretWord}");
    





