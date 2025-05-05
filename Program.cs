using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWithMoshArrayListExercise04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 3 - Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
             */

            Console.WriteLine("Please enter 5 numbers: ");

            var store = new int[5];

           
            for (int i = 0; i < store.Length; i++)
            {
                store[i] = Convert.ToInt32(Console.ReadLine());

                if (i == store[i])
                {
                    Console.WriteLine("You've entered the same number, please re enter: ");
                    store[i] = Convert.ToInt32(Console.ReadLine());
                }
   
            }

            Console.WriteLine();
            Console.WriteLine();

            Array.Sort(store);
            foreach (int j in store)
            {
                Console.WriteLine(j);
            }

            


        }
    }
}
