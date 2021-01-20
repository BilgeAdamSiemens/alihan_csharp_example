using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int shouldBeTotal = GetIntFromConsole("Total Should be: ");
            int[] elements = GetValuesFromConsole("Should be values: ");

            int? minSize = GetMinSizeOfTheSolution(elements, shouldBeTotal);


            Console.WriteLine();
            bool isFinish = false;

            while (!isFinish)
            {
                int[] solution = GetValuesFromConsole("Give The solution: ");
                bool isTrueGiven = IsTrueGiven(elements, solution);


                if (isTrueGiven && solution.Sum() == shouldBeTotal && solution.Length == minSize)
                {
                    Console.WriteLine("Dogru ve kazandın");
                    isFinish = true;
                }
                else if(isTrueGiven && solution.Sum() == shouldBeTotal){
                    Console.WriteLine("Dogru");
                }
                else
                    Console.WriteLine("Yanlis");
                Console.WriteLine();
            }

        }



        static bool IsTrueGiven(int[] values, int [] solution)
        {
            List<int> tmp = values.ToList();

            foreach(int value in solution)
            {
                if (tmp.Contains(value))
                    tmp.Remove(value);
                else
                    return false;
            }

            return true;
        }


        static int GetIntFromConsole(String message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }


        static int[] GetValuesFromConsole(String message)
        {
            Console.Write(message);
            String givenText = Console.ReadLine();

            return givenText.Split(' ').Select(int.Parse).ToArray();



        }



        static int? GetMinSizeOfTheSolution(int[] values, int total)
        {

            int? minSize = null;

            // küme elemanları diyelimki {2, 3, 4} olsun bu 2^3 kere farklı şeçimi vardır.
            double combinationsCount = Math.Pow(2, values.Length);

            // boş elemanlı kümeyi '{}' saymazsak 2^3 - 1 tane var o yüzden 1 den başlattık
            for (int i = 1; i < combinationsCount; i++)
            {

                // olası şeçimler
                List<int> selectedValues  = new List<int>();

                // number convert to binary string example 5 => '101'
                string binaryString = Convert.ToString(i, 2).PadLeft(values.Length, '0');
                
                // olası şeçimleri dolduruluyor
                for (int j = 0; j < binaryString.Length; j++)
                {
                    if (binaryString[j] == '1')
                    {
                        selectedValues.Add(values[j]);
                    }
                }


                // olası şeçim elemanların toplamı istedigimiz sonucu veriyor ve eleman uzunlugu en küçükmü
                if (selectedValues.Sum() == total)
                {
                    if (minSize == null || minSize > selectedValues.Count)
                        minSize = selectedValues.Count;
                    
                }

            }

            if (minSize == null)
                throw new NotFoundException("Don't Find the solution");


            return minSize;
        }


    }

    class NotFoundException : Exception
    {
        public NotFoundException(String message) : base(message)
        {

        }

    }
}
