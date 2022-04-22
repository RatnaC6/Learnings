using System;
using System.Collections.Generic;
using System.Linq;

namespace Sess1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>()
            {
                "abc","pqr","xyz","jkl","mno", "demo", "blah"
            };

            //var allWords = from w in words
            //               select w;

            //foreach (var word in allWords)
            //{
            //    Console.WriteLine(word);
            //}

            var threeLetterWords = from w in words
                                   where w.Length == 3
                                   select w;

            foreach (var word in threeLetterWords)
            {
                Console.WriteLine(word);
            }

            var threeLetterWordsAlphabetic = from w in words
                                             where w.Length == 3
                                             orderby w
                                             select w;

            foreach (var word in threeLetterWordsAlphabetic)
            {
                Console.WriteLine(word);
            }
        }
    }
}
