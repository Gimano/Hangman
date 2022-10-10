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
        public static string HangmanWord() //metod i class Word som har string array
        {
             string[] huvudstaden =  
             {
            "stockholm",
            "tokyo",
            "honolulu",
            "beijing",
            "washington dc",
            "canberra",
            "budapest",
            "helsinki",
            "ottowa",
            "soeul",
            };  
            var chosenWord = huvudstaden[new Random().Next(0, huvudstaden.Length - 1)];
            return chosenWord;
        }

    }
}