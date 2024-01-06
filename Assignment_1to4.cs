using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETTraining
{
    class Assignment_1to4
    {
        static void Main(string[] args)
        {
            //Assignment 1 and 2
            Console.WriteLine("Assignment 1 and 2");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Hi !" + name);
            Console.WriteLine("Welcome to the world of C#");
            Console.WriteLine("---------------------------");

            //Assignmet 3
            Console.WriteLine("Assignment 3:");
            Console.WriteLine("Enter two nos to display all number between them:");
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            for(;i<=j;i++)
            {
                Console.WriteLine(i);
            }

            ////Assignmet 4
            Console.WriteLine("---------------------------");
            Console.WriteLine("Assignment 4:");
            Console.WriteLine("Enter a nos to find whether its ODD or EVEN:");
            int no = int.Parse(Console.ReadLine());
            if (no % 2 == 0)
            {
                Console.WriteLine("Number " + no + "is an EVEN number");
            }
            else
                Console.WriteLine("Number " + no + "is an ODD number");







        }
    }
}
