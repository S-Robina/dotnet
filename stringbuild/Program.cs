
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuild
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine("Hello");
            sb.AppendLine("Hi");
            Console.WriteLine(sb);


            //classes
            namespaceExample add = new namespaceExample();


            Console.WriteLine(add.Sum(5, 4));

            Console.ReadKey();


        }
    }
}
