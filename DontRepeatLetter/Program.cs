using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oderrer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                String theText = GetWordFromConsole("Enter The Text");

                char cc = FindFirstUniqueChar(theText);
                Console.WriteLine(cc);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(LetterNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
           

           

        }

        static String GetWordFromConsole(String message)
        {
            Console.WriteLine(message);
            return Console.ReadLine().Trim();
        }

        static char FindFirstUniqueChar(String word)
        {
            if (word.Length < 2)
                throw new ArgumentOutOfRangeException("The word length should be greater than one");

            List<char> inChars = new List<char>();
            List<char> notInChars = new List<char>();

            foreach(char letter in word)
            {
                if (!inChars.Contains(letter))
                {
                    if (notInChars.Contains(letter))
                    {
                        notInChars.Remove(letter);
                        inChars.Add(letter);
                    }
                    else
                    {
                        notInChars.Add(letter);
                    }
                }
            }

            if (notInChars.Count == 0)
                throw new LetterNotFoundException("Unique letter not found!");

            return notInChars[0];


        }
    }

    class LetterNotFoundException : Exception
    {
        public LetterNotFoundException(String message):base(message)
        {

        }
    }
}
