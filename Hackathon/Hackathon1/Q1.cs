using System;
using System.Collections.Generic;
using System.Linq;
namespace Hackathon
{
    internal class Q1
    {
        static void Main()
        {
            Console.WriteLine("Write the sentence: ");
            string sentence = Console.ReadLine();
            Count(sentence);
        }

        private static void Count(string sentence)
        {
            string[] words = sentence.ToLower().Split(' ', '.','!');
            Dictionary<string, int> wordFreq = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordFreq.ContainsKey(word))
                    wordFreq[word]++;
                else
                    wordFreq[word] = 1;
            }
            Display(wordFreq);
        }

        private static void Display(Dictionary<string, int> wordFre)
        {
            var wordFreq = new List<KeyValuePair<string, int>>(wordFre);
            for (int i = 0; i < wordFreq.Count - 1; i++)
            {
                for (int j = 0; j < wordFreq.Count - i - 1; j++)
                {
                    if (wordFreq[j].Value < wordFreq[j + 1].Value)
                    {
                        var temp = wordFreq[j];
                        wordFreq[j] = wordFreq[j + 1];
                        wordFreq[j + 1] = temp;
                    }
                }
            }
            foreach (var pair in wordFreq)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

    }
}
