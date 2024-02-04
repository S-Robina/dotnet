using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("hello world");

            /* string a = "Ayush";
             string b = "Pakhrin";
             string c = "Tamang";
             string concat;
             concat = a + b + c;
             Console.WriteLine(concat);
            */

            /* int a = 100;
             int b = 50;
             Console.WriteLine(a + b);
             Console.WriteLine(a - b);
             Console.WriteLine(a * b);
             Console.WriteLine(a / b);
             Console.WriteLine(a % b);
            */

            /* int a;
             Console.WriteLine("Enter a Number");
             a = int.Parse(Console.ReadLine());
             Console.WriteLine(a);
            */

            float num = 3.14f;
            int integer = (int) num;
            Console.WriteLine($"After explicit num={integer}");

            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();
            Console.WriteLine($"You are {input} years old!");

        }
    }
}
