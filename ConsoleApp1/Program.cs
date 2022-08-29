using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lokes Bot");

            Wizard();


            Console.ReadKey();
        }

        static void Wizard()
        {
            double age = 99.9;
            Console.WriteLine(age);

            Console.WriteLine("Please enter your name:");
            string name= Console.ReadLine();
            Console.WriteLine("Hello "+name+" Have a great day");
        }

    }
}
