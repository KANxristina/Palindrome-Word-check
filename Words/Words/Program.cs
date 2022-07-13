using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Words
{
    class Program
    {    
        public static string ReverseWord(string word)
        {
            char[] c = word.ToCharArray();
            Array.Reverse(c);        
            string word2= new string (c);
            Console.WriteLine($"{word2}");
            Check(word, word2);
            Console.WriteLine("Another Word? If you want to exit type 'STOP'");
           string option= Console.ReadLine();
            if (option != "stop" && option != "Stop" && option != "STOP")
            {
                ReverseWord(option);
            }
            else
            {
                Console.WriteLine("Bye!");
            }
          
            return word2;       
        }
        public static bool Check(string word,string word2)
        {
            if (word == word2)
            {
                Console.WriteLine("Same");
                return true;
            }
            else
            {
                Console.WriteLine("Not the same word when reversed");
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give word:");
            string word=Console.ReadLine().Trim();
            ReverseWord(word);
        }
    }
}
