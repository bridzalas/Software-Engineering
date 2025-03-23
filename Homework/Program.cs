using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence,newSentence, word, newWord;
            Console.WriteLine("Write any sentence.");
            sentence=Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Write a word that you want to replace.");
            word = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Write a new word that you want to replace that last word with.");
            newWord = Console.ReadLine();
            Console.WriteLine();
            newSentence = sentence.Replace(word, newWord);
            if(newSentence==sentence)
            {
                Console.WriteLine("The sentence remains the same, the word that you entered doesn't exist in your sentence.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Sentence after replacing word '{0}' with word '{1}'", word, newWord);
                Console.WriteLine(newSentence);
                Console.WriteLine();
            }
            


        }
    }
}
