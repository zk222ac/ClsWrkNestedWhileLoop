using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // how to declare the while loop 

            // initialize counter
            int i = 0;

            // define while loop
            // outer loop
            while (i < 10)
            {
                Console.WriteLine("Outer loop while loop .....");
                // inner while loop
                int j = 0;
                while (j < 5)
                {
                    int k = 0;
                    while (k < 3)
                    {
                        Console.WriteLine(" loop inside inner loop...");
                        k++;
                    }
                    Console.WriteLine("Inner while loop....... ");
                    j++;
                }

                // incremental counter
                i++;
            }

            Console.ReadKey();

        }
    }
}
