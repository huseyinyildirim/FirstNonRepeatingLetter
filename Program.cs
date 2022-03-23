using System;
using System.Collections.Generic;
using System.Linq;

namespace Case
{
    class Program
    {
        public class LetterList
        {
            public char Letter { get; set; }
            public int LetterCount { get; set; }
        }

        static void Main(string[] args)
        {
            Method1();
            Method2();
        }

        static void Method1()
        {
            string text = "geeksforgeeks";

            List<LetterList> letterList = new List<LetterList>();

            foreach (var letter in text)
            {
                if (letterList.Select(x => x.Letter).Contains(letter))
                {
                    letterList.Where(x => x.Letter == letter).ToList().ForEach(s => s.LetterCount++);
                }
                else
                {
                    letterList.Add(new()
                    {
                        Letter = letter,
                        LetterCount = 1
                    });
                }
            }

            var result = letterList.FirstOrDefault(x => x.LetterCount == 1);

            Console.WriteLine(result.Letter);
        }

        static void Method2()
        {
            string text = "gxeeksforgeeks";

            var letterDic = new Dictionary<char, int>();

            foreach (var letter in text)
            {
                if (letterDic.ContainsKey(letter))
                {
                    letterDic[letter]++;
                } else
                {
                    letterDic.Add(letter, 1);
                }
            }

            var result = letterDic.FirstOrDefault(x => x.Value == 1);

            Console.WriteLine(result.Key);
        }
    }
}
