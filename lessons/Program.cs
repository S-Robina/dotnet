using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            //Playing with Strings
                        string name = "Duck Academy";//Concatenation
                        Console.WriteLine(name);//printing length
                        Console.WriteLine(name.Length);//finding Length
                        Console.WriteLine(name.ToUpper());//uppercase
                        Console.WriteLine(name.Contains("Duck"));//Check whetheer the string have the value or not.
                        Console.WriteLine(name[2]);//Check and print the words.
                        Console.WriteLine(name.IndexOf("Academy"));//academy starts at index 5.i.e array[5]="a";
                        Console.WriteLine(name.Substring(5));//only prints academy  i.e starts to print form 5th index.
                        Console.WriteLine(name.Substring(5, 5));//prints from 5th index and upto 5th index only i.e 10th for full array*/


            /*            //Working With numbers
                        *//*int a = 6;decimal b = 4;//two type of datatypes for numbers*/
            /*a--;//decrement*//*
            Console.WriteLine(Math.Abs(-90));//Gives absolute value i.e. 40;
            Console.WriteLine(Math.Pow(2.2,2));//Takes first as value and second as power.
            Console.WriteLine(Math.Round(4.5));
            Console.ReadKey();*/

            /*            //Getting input from users.
                        Console.Write("Enter Your Name: ");
                        string name=Console.ReadLine();
                        Console.Write("Enter your Age:");
                        int age=int.Parse(Console.ReadLine());
                        Console.WriteLine($"Hello {name}! You are {age} years old.");
                        Console.ReadLine();*/

            //Building Mad lib

            /*            string color, plural, cel;
                        Console.Write("Enter a color:");
                        color= Console.ReadLine();
                        Console.Write("Enter a Plural:");
                        plural= Console.ReadLine();
                        Console.Write("Enter your fav cel:");
                        cel= Console.ReadLine();

                        Console.WriteLine($"Roses are {color}");
                        Console.WriteLine($"{plural} are blue");
                        Console.WriteLine($"I love {cel}");
            */

            //Arrays:
            /*            int [] luckyNumber = {4,8,15,16,23,42};
                        luckyNumber[1] = 900;
                        string[] friends = new string[10];
                        friends[0] = "Ayush";
                        friends[1] = "Kelly";

                        Console.WriteLine(luckyNumber[1]);//printing indiv value;
                        for (int i = 0; i < luckyNumber.Length; i++)
                        {
                            Console.WriteLine(luckyNumber[i]);
                        }

            */
            /*            //Calling Method
                        Greet();
                        Add(1,2);
            */

            //Return Statements:
            Console.WriteLine(Cube(5));
            Console.WriteLine(Hello("Namaste"));


            Console.ReadKey();
        }
        //Return
        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }
        static string Hello(string lang)
        {
            return $"Hello {lang}";
        }












        /*        //method
                static void Greet()
                {
                    string name;
                    Console.Write("Enter your name:");
                    name=Console.ReadLine();
                    Console.WriteLine($"Namaste {name}!");
                }
                //Method with Parameters and arguement
                static void Add(decimal num1,decimal num2)
                {
                    Console.WriteLine(num1+num2);
                }*/
    }
}