using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Word
    {
        public static void HangmanWord() //metod i class Word som har string array
        {
             string[] huvudstaden =  
             {
            "Stockholm",
            "Tokyo",
            "Honolulu",
            "Beijing",
            "Washington DC",
            "Canberra",
            "Budapest",
            "Helsinki",
            "Ottowa",
            "Soeul",
            };  
            var chosenWord = huvudstaden[new Random().Next(0, huvudstaden.Length - 1)];
        }
    }
}