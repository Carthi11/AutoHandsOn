using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETTraining.Assignment
{
    class Assignment_16
    {
        static void Main(string[] args)
        {
            int[] mark = new int[15];
            int sum = 0;
            float avg = 0.0f;
            int temp = 0;
            int i = 0;
            int j = 0;
            int c = 10;
            Console.WriteLine("Enter ten Mark: ");

            for (i = 0; i < 10; i++)
            {
                mark[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            //Sum of a total Marks:
            for (i = 0; i < 10; i++)
            {
                sum = sum + mark[i];
            }
            Console.WriteLine("Total mark is " + sum);
            Console.WriteLine("--------------------------------------------------------------------------------");
            //Average of a total Marks:
            avg = (sum / c);
            Console.WriteLine("Average mark is " + avg);
            Console.WriteLine("--------------------------------------------------------------------------------");
            //Sort the marks in ascending order
            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (mark[i] > mark[j])
                    {
                        temp = mark[i];
                        mark[i] = mark[j];
                        mark[j] = temp;
                    }
                }
            }
            Console.Write("Marks in ascending order\n");
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (i = 0; i < 10; i++)
            {

                Console.WriteLine(mark[i]);

            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Minimum marks is " + mark[0]);
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (mark[i] < mark[j])
                    {
                        temp = mark[i];
                        mark[i] = mark[j];
                        mark[j] = temp;
                    }
                }
            }
            Console.Write("Maximum marks is " + mark[0] + "\n");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("Marks in descending order\n");
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (i = 0; i < 10; i++)
            {

                Console.Write(mark[i] + "\n");

            }
        }



    }

}