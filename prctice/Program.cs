using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prctice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n}* {i} = {n * i}");

            }

            /*            int i = 0;
                        while (i < 10)
                        {
                            Console.WriteLine(i);
                            i++;
                        }*/

            /*         int i = 0;
                     do
                     {
                         if (i % 2 == 0)
                         {
                             Console.WriteLine(i);
                         }
                         i++;
                     }
                     while (i <= 10);*/




        }
    }
}
