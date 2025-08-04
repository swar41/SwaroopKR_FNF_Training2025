using System;
using System.Collections.Generic;
using System.Linq;

namespace Hackathon
{
    internal class Q2
    {
        static List<string> SortTitles(List<string> books)
        {
            var bookInfo = new List<(string author, string title)>();

            foreach (var entry in books)
            {
                var parts = entry.Split(" by ");
                string title = parts[0].Trim('"');
                string author = parts[1].Split("and")[0];

                bookInfo.Add((author, title));
            }
            return sort(bookInfo);
        }

        //private static List<string> sort(List<(string author, string title)> bookInfo)
        //{
        //    var sorted = bookInfo.OrderBy(b => b.author).ThenBy(b => b.title);
        //    return sorted.Select(b => b.title).ToList();
        //}
        private static List<string> sort(List<(string author, string title)> bookInfo)
        {
            for (int i = 0; i < bookInfo.Count - 1; i++)
            {
                for (int j = 0; j < bookInfo.Count - i - 1; j++)
                {
                    bool shouldSwap = false;
                    if (string.Compare(bookInfo[j].author, bookInfo[j + 1].author) > 0)
                    {
                        shouldSwap = true;
                    }
                    else if (bookInfo[j].author == bookInfo[j + 1].author &&
                             string.Compare(bookInfo[j].title, bookInfo[j + 1].title) > 0)
                    {
                        shouldSwap = true;
                    }

                    if (shouldSwap)
                    {
                        var temp = bookInfo[j];
                        bookInfo[j] = bookInfo[j + 1];
                        bookInfo[j + 1] = temp;
                    }
                }
            }
            List<string> sortedTitles = new List<string>();
            foreach (var book in bookInfo)
            {
                sortedTitles.Add(book.title);
            }

            return sortedTitles;
        }
        private static List<string> addBooks(List<string> books)
        {
            do
            {
                Console.WriteLine("enter the book info,,,enter done to stop inputting");
                string b = Console.ReadLine();

                if (b.ToLower() == "done")
                {
                    return books;
                }
                books.Add(b);
                
            } while (true);
        }
        static void Main()
        {
            //var books = new List<string>
            //{
            //    "\"The Canterbury Tales\" by Chaucer",
            //    "\"Algorithms\" by Sedgewick",
            //    "\"The C Programming Language\" by Kernighan and Ritchie",
            //    "\"The silent patient\" by Unknown",
            //    "\"Not silent patient\" by Unknown"
            //};
            List<string> books=new List <string>();
            addBooks(books);
            
            var sortedTitles = SortTitles(books);
"
            Console.WriteLine("Sorted Titles :::::");
            foreach (var title in sortedTitles)
            {
                Console.WriteLine(title);
            }
        }
    }
}