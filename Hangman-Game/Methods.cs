using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game
{
    internal class Methods
    {
        
        public static string[] Words()
        {
            return new string[]
            {
                "äpple", "banan", "citron", "druva",
                "granatäpple", "hallon", "kiwi",
                "nektarin", "appelsin", "päron",
                "smultron", "vindruva"
            };
        }

       
        public static string Random()
        {
            Random random = new Random();
            string[] words = Words();
            return words[random.Next(words.Length)];
        }

      
        public static char[] InitializeDisplayWord(string secretWord)
        {
            char[] displayWordLength = new char[secretWord.Length];
            for (int i = 0; i < secretWord.Length; i++)
            {
                displayWordLength[i] = '_';
            }
            return displayWordLength;
        }
    }
}
