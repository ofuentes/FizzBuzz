using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 3)
                {
                    throw new Exception("Invalid parameters!");
                }
                else
                {
                    // Get the collection
                    string[] collection = args[0].Split(',');

                    // Lower number
                    int lower;
                    if (!Int32.TryParse(args[1], out lower))
                    {
                        throw new Exception("Invalid value for the lower number");
                    }

                    // higher number
                    int higher;
                    if (!Int32.TryParse(args[2], out higher))
                    {
                        throw new Exception("Invalid value for the higher number");
                    }

                    ProcessCollection(collection, lower, higher);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PrintUse();
            }
        }

        private static void ProcessCollection(string[] collection, int lower, int higher)
        {
            int number;
            StringBuilder result = new StringBuilder();
            bool divisible = false;
            foreach (string item in collection)
            {
                divisible = false;
                if (Int32.TryParse(item, out number))
                {
                    // Check if divisible by the lower number
                    if (number % lower == 0)
                    {
                        Console.Write("Fizz");
                        result.Append(String.Format("Divided: {0} by: {1}\n", number, lower));
                        divisible = true;
                    }

                    // Check if divisible by the higher number
                    if (number % higher == 0)
                    {
                        Console.Write("Buzz");
                        result.Append(String.Format("Divided: {0} by: {1}\n", number, higher));
                        divisible = true;
                    }

                    // Check if not divisible
                    if (!divisible)
                    {
                        result.Append(String.Format("{0} - N/A\n", number));
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                else
                {
                    result.Append(String.Format("{0} is not a valid entry\n",item));
                }

            }

            Console.WriteLine("------- Done! -------");
            Console.Write(result.ToString());
            Console.WriteLine();
            Console.WriteLine("Developed by: Omar A. Fuentes");

        }

        private static void PrintUse()
        {
            Console.WriteLine("Use: FizzBuzz <collection> <lowerNumber> <higherNumber>");
            Console.WriteLine("For the collection please use a comma to separate each element and do not include any spaces");
            Console.WriteLine();
        }
    }
}
