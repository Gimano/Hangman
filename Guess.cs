using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal static class Guess
    {

        public static void RunGame()
        {
            Console.Clear();
            int lives = 5;
            string secret = Word.HangmanWord();
            var letters = new List<string>();

            while (lives != 0)
            {
                int charactersLeft = 0;


                foreach (string c in letters)
                {
                    Console.Write(c);
                }
                Console.WriteLine("\n");

                foreach (char character in secret)
                {
                    string letter = character.ToString();

                    if (letters.Contains(letter))
                    {
                        Console.Write(letter);
                    }
                    else
                    {
                        Console.Write("_");
                        charactersLeft++;
                    }
                }

                Console.WriteLine("\n");

                if (charactersLeft == 0)
                {
                    break;
                }

                Console.Write("Skriv in en bokstav: ");

                var key = Console.ReadKey().Key.ToString().ToLower();
                Console.Clear();
                
                if (letters.Contains(key))
                {
                    Console.WriteLine("Du har redan försökt med den bokstaven!");
                    continue;
                }

                letters.Add(key);

                if (!secret.Contains(key))
                {
                    lives--;

                    if (lives > 0)
                    {
                        Console.WriteLine($"Bokstaven {key} finns inte i ordet. Du har {lives} liv kvar.");
                    }
                }
            }
            if (lives > 0)
            {
                Console.WriteLine($"Du vann med {lives} liv kvar!");
            }
            else
            {
                Console.WriteLine($"Du förlorade! Ordet var {secret}.");
            }
        }
    }
}
