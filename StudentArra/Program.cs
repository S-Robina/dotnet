using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentArra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Total num of student:");
            int length=int.Parse(Console.ReadLine());
            Console.Clear();
            string[] studentName=new string[length];

            for(int i=0; i<length; i++)
            {
                Console.WriteLine("Enter Student Name:");
                studentName[i]=Console.ReadLine();
            }
            Array.Sort(studentName);
            for(int i=0; i<studentName.Length ; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank+"."+studentName[i]);
            }
            
            Console.ReadLine();
        }
    }
}
