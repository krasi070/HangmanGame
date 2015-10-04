using System;
using System.Text.RegularExpressions;
using System.Linq;

class AlphaVerOfTheGame
{
    static void Main()
    {
        string typedWord = EnterEnglishWord();
        string[] hiddenWord = new string[typedWord.Length];
        int countHiddenLetters = 0;
        string winOrLose = "You lose!";
        for (int i = 0; i < typedWord.Length; i++)
        {
            hiddenWord[i] = "*";
        }
        Console.Clear();
        char[] distinctLetters = typedWord.Distinct().ToArray();
        int numberOfTries = distinctLetters.Length + distinctLetters.Length / 2 + 1;
        Console.WriteLine("Word length: {0,-10}Number of tries: {1}", typedWord.Length, numberOfTries);
        for (int i = 0; i < numberOfTries; i++)
        {
            if (i == numberOfTries - 1)
            {
                Console.Write("Last try: ");
            }
            else
            {
                switch (i)
                {
                    case 0:
                        {
                            Console.Write("{0}st try: ", 1);
                        }
                        break;
                    case 1:
                        {
                            Console.Write("{0}nd try: ", 2);
                        }
                        break;
                    case 2:
                        {
                            Console.Write("{0}rd try: ", 3);
                        }
                        break;
                    default:
                        {
                            Console.Write("{0}th try: ", i + 1);
                        }
                        break;
                }
            }
            string input = CheckIfLetterOrWordIsValid(typedWord, i);
            if (input.Length == 1)
            {
                for (int j = 0; j < typedWord.Length; j++)
                {
                    if (input == typedWord[j].ToString())
                    {
                        hiddenWord[j] = input;
                    }
                    Console.Write(hiddenWord[j]);
                    if (hiddenWord[j] == "*")
                    {
                        countHiddenLetters++;
                    }
                }
                if (countHiddenLetters == 0)
                {
                    Console.WriteLine();
                    winOrLose = "You win!";
                    break;
                }
                else
                {
                    countHiddenLetters = 0;
                }
            }
            else
            {
                if (input == typedWord)
                {
                    winOrLose = "You win!";
                    break;
                }
                else
                {
                    foreach (var letter in hiddenWord)
                    {
                        Console.Write(letter);
                    }
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine(winOrLose);
        //Console.WriteLine(typedWord);
    }
    static string EnterEnglishWord()
    {
        string hiddenWord = "";
        string typedWord = "";
        string currTypedWord = "";
        ConsoleKeyInfo readKey;
        int wordLength = 0;
        do
        {
            readKey = Console.ReadKey();
            switch (readKey.Key)
            {
                case ConsoleKey.A:
                    {
                        Console.Clear();
                        typedWord += "a";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.B:
                    {
                        Console.Clear();
                        typedWord += "b";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.Backspace:
                    {
                        Console.Clear();
                        if (wordLength > 0)
                        {
                            wordLength--;
                            hiddenWord = new string('*', wordLength);
                        }
                        typedWord = currTypedWord;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.C:
                    {
                        Console.Clear();
                        typedWord += "c";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.D:
                    {
                        Console.Clear();
                        typedWord += "d";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.E:
                    {
                        Console.Clear();
                        typedWord += "e";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.F:
                    {
                        Console.Clear();
                        typedWord += "f";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.G:
                    {
                        Console.Clear();
                        typedWord += "g";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.H:
                    {
                        Console.Clear();
                        typedWord += "h";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.I:
                    {
                        Console.Clear();
                        typedWord += "i";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.J:
                    {
                        Console.Clear();
                        typedWord += "j";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.K:
                    {
                        Console.Clear();
                        typedWord += "k";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.L:
                    {
                        Console.Clear();
                        typedWord += "l";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.M:
                    {
                        Console.Clear();
                        typedWord += "m";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.N:
                    {
                        Console.Clear();
                        typedWord += "n";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.O:
                    {
                        Console.Clear();
                        typedWord += "o";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.P:
                    {
                        Console.Clear();
                        typedWord += "p";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.Q:
                    {
                        Console.Clear();
                        typedWord += "q";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.R:
                    {
                        Console.Clear();
                        typedWord += "r";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.S:
                    {
                        Console.Clear();
                        typedWord += "s";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.T:
                    {
                        Console.Clear();
                        typedWord += "t";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.U:
                    {
                        Console.Clear();
                        typedWord += "u";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.V:
                    {
                        Console.Clear();
                        typedWord += "v";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.W:
                    {
                        Console.Clear();
                        typedWord += "w";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.X:
                    {
                        Console.Clear();
                        typedWord += "x";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.Y:
                    {
                        Console.Clear();
                        typedWord += "y";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                case ConsoleKey.Z:
                    {
                        Console.Clear();
                        typedWord += "z";
                        hiddenWord += "*";
                        wordLength++;
                        Console.Write(hiddenWord);
                    }
                    break;
                default:
                    {
                        Console.Clear();
                    }
                    break;
            }
            currTypedWord = "";
            for (int i = 0; i < typedWord.Length - 1; i++)
            {
                currTypedWord += typedWord[i];
            }
        } while (readKey.Key != ConsoleKey.Enter);
        return typedWord;
    }
    static string CheckIfLetterOrWordIsValid(string secretWord, int i)
    {
        string enteredLetterOrWord = "";
        do
        {
            enteredLetterOrWord = Console.ReadLine().ToLower();
            if (!(enteredLetterOrWord.Length == 1 ^ enteredLetterOrWord.Length == secretWord.Length))
            {
                Console.Write("Invalid input!\n{0}{1} try: ",
                    i == (secretWord.Length - 1) ? "La" : (i + 1).ToString(),
                    (i == 0 || i == secretWord.Length - 1) ? "st" : (i == 1 ? "nd" : (i == 2 ? "rd" : "th")));
            }
            else if (!(Regex.IsMatch(enteredLetterOrWord, @"^[a-z]+$")))
            {
                Console.Write("Invalid input!\n{0}{1} try: ",
                    i == (secretWord.Length - 1) ? "La" : (i + 1).ToString(),
                    (i == 0 || i == secretWord.Length - 1) ? "st" : (i == 1 ? "nd" : (i == 2 ? "rd" : "th")));
            }
            else
            {
                break;
            }
        } while (true);
        return enteredLetterOrWord;
    }
}
