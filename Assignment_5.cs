using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETTraining.Training
{
    class Assignment_5

    {
        static void Main(string[] args)
        {
            //5.	Write a program in C# to find the total number of odd and even numbers accepted from the user.
            Console.WriteLine("Assignment 5:");
            Console.WriteLine("Enter two nos to display total number of odd and even numbers:");
            int n = Convert.ToInt32(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            int o = 0, e = 0;
            Console.WriteLine("Enter the number to count");            
            for (; n <= j; n++)
            {
                if (n % 2 == 0)
                {                    
                    e++;

                }
                else
                {
                    o++;
                }
            }
            Console.WriteLine("The even number count is:" + e);
            Console.WriteLine("The odd number count is:" + o);

        }
    }
}
