using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETTraining.Assignment
{
    class Assignment_6
    {
        static void Main(string[] args)
        {
            //6.Write a program in C# to display temperature in Celsius. Accept the temperature in Fahrenheit.
            float celsius;
            Console.WriteLine("Enter Fahrenheit temperature : ");
            float fahrenheit = float.Parse(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The converted Celsius temperature is " + celsius);            
        }
    }
}
