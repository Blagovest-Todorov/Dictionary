using System;
using System.Collections.Generic;
using System.Linq;

namespace words
{
    class Program
    {
        static void Main(string[] args)
        {           
            Dictionary<string, List<string>> synonims = new Dictionary<string, List<string>>();

            int countWords = int.Parse(Console.ReadLine());

            for (int i = 0; i < countWords; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (synonims.ContainsKey(word))
                {
                    synonims[word].Add(synonim);
                }
                else //!synonim.containsKey(word)
                {
                    synonims.Add(word, new List<string>()); //create new key and empty List
                    synonims[word].Add(synonim); // fill to the current key - > fill the list value
                }
            }

            foreach (var item in synonims)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }           
        }
    }
}
