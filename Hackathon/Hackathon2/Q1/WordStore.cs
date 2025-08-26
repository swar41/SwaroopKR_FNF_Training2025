using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebFormsApp.Hackathon2.Q1
{
    public class WordTranslation
    {
        public string Word { get; set; }
        public string Translation { get; set; }
    }

    public static class WordStore
    {
        public static List<WordTranslation> Words;

        static WordStore()
        {
            Words = new List<WordTranslation>();
        }

        public static WordTranslation Find(string word)
        {
            if (string.IsNullOrWhiteSpace(word)) return null;
            return Words.Find(w => w.Word.ToLower() == word.ToLower());
        }

        public static void Add(string word, string translation)
        {
            Words.Add(new WordTranslation { Word = word, Translation = translation });
        }

        public static List<WordTranslation> GetAll()
        {
            return Words;
        }
    }


}
