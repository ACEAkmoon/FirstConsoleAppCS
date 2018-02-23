using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int num_1 = 0, num_2 = 0, sum = 0;
            int sum = 0;
            List<int> nums = new List<int>();

            Console.WriteLine("Guess my desire: Enter the Num-1, from 1 to 10");
            //num_1 = Convert.ToInt32(Console.ReadLine());
            nums.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("\nEnter the Num-2, from 1 to 10");
            //num_2 = Convert.ToInt32(Console.ReadLine());
            nums.Add(Convert.ToInt32(Console.ReadLine()));

            //if (num_1 != 0 && num_2 != 0)
            if (nums.Count == 2)
            {
                //sum = num_1 + num_2;
                sum = nums.ToArray().Sum();
                Console.WriteLine("\nYour amount is: " + sum);
            }
            else
            {
                Console.WriteLine("\nError: Press key");
            }
            if (sum == 7)
            {
                string[] array_names = new string[4]
                {
                    "I", "want", "you!", ":*)"
                };
                Console.Write("\nFine you guessed, my desire is: ");
                for (int i = 0; i < array_names.Length; i++)
                {
                    Console.Write(array_names[i] + " ");
                }
                Console.WriteLine("\n\nPress the key to <START>");
            }
            else
            {
                Console.WriteLine("\nSorry, you not did guess my desire! :(\n\nPress key to exit");
            }
            Console.ReadKey();
        }
    }
}
