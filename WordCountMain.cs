using System;
using System.Linq;


namespace WordCount
{
    class WordCountMain
    {
        static void Main(string[] args)
        {
            const string statement = "This is a statement, and so is this.";

            var split = statement.Split(new[] {' ', ',', '.'});

            var wordGroups = split.Where(s => !string.IsNullOrEmpty(s)).GroupBy(i => i, (word, words) => new {Word = word, Count = words.Count()},
                StringComparer.OrdinalIgnoreCase).ToList();

            foreach (var w in wordGroups)
            {
                Console.WriteLine("{0} - {1}", w.Word, w.Count);
            }


            Console.ReadLine();

        }
    }
}
