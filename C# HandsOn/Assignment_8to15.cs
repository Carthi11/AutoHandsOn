using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETTraining.Assignment
{
    class Assignment_8to15
    {
        static void Main(string[] args)
        {                                                            
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Enter the corresponding number to perfom an action : ");          
            Console.WriteLine("1. Print the series: 0,1,4,9,16,.....625");
            Console.WriteLine("2. Find the factorial of the given number.");
            Console.WriteLine("3. Generate a Fibonacci series till 40");
            Console.WriteLine("4. type an integer N and computes the sum of the cubes from 5 to the power 3  to N the power 3");
            Console.WriteLine("5. Find the multiplication table of the given number till 20");
            Console.WriteLine("6. Print the numbers divisible by 7 between 200 and 300");
            Console.WriteLine("7. Find the largest of the given three numbers. Accept the numbers from the users.");
            Console.WriteLine("8. Find the smallest of five numbers accepted from the user");
            Console.WriteLine("--------------------------------------------------------------------------------");
            string number = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            int p=0;
            switch(number)
            {
                //8.Write a program to print the series: 0,1,4,9,16,.....625
                case "1":
                    
                    Console.WriteLine("Number Series are: ");
                    int series = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    for (int s = 1; s<=series; s++)
                    {
                        Console.WriteLine(s*s);
                    }
                    //Console.WriteLine("" + p);
                    break;

                //9.Write a program in C# to find the factorial of the given number.
                case "2":
                    int k, f = 1, num;

                    Console.WriteLine("Input the number : ");
                    num = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    for (k = 1; k <= num; k++)
                        f = f * k;
                    Console.WriteLine("The Factorial of {0} is: {1}\n", num, f);
                    break;

                //10.Write a program in C# to generate a Fibonacci series till 40.
                case "3":
                    int p1 = 0, p2 = 1, p3, f1, num1;
                    Console.WriteLine("Input the number for fibonacci series : ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.Write("Here is the fibonacci series upto  to {0} terms : \n", num1);
                    Console.Write("{0}    {1}", p1, p2);

                    for (f1 = 3; f1 <= num1; f1++)
                    {
                        p3 = p1 + p2;
                        Console.Write("  {0}  ", p3);
                        p1 = p2;
                        p2 = p3;
                    }
                    Console.Write("\n");            
                break;

                //11.Write a program that asks the user to type an integer N and computes the sum of the cubes from 5 to the power 3  to N the power 3
                case "4":

                    int c1, cube, d=0;
                    Console.WriteLine("Input number of terms : ");
                    cube = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    for (c1 = 1; c1 <= cube; c1++)
                    {

                        Console.Write("Number is : {0} and cube of the {1} is :{2} \n", c1, c1, (c1 * c1 * c1));
                        d += c1 * c1 * c1;
                    }                    
                    Console.WriteLine("Sum of Cube: " + d);

                    break;
                
                //12.Write a program in C# to find the multiplication table of the given number till 20.
                case "5":
                    int i, j, n;
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.Write("Multiplication table from 1 to {0} \n", n);
                    for (i = 1; i <= 20; i++)
                    {
                        for (j = n; j <= n; j++)
                        {
                            if (j <= n - 1)
                                Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                            else
                                Console.Write("{0}x{1} = {2}", j, i, i * j);

                        }
                        Console.Write("\n");
                    }
                    break;
                
                //13.Write a program to print the numbers divisible by 7 between 200 and 300.                
                case "6":
                    Console.Write("Enter the range divisible by 7:");
                    int s1 = int.Parse(Console.ReadLine());
                    int s2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    for (int c = s1; s1<s2; s1++)
                    {
                        if (s1 % 7 == 0)
                            Console.WriteLine(s1);
                    }
                    break;

                //14.Write a program in C# to find the largest of the given three numbers. Accept the numbers from the users.                
                case "7":
                    int l1, l2, l3;
                    Console.WriteLine("Find the largest of three numbers:\n");
                    Console.WriteLine("Enter the three numbers:");
                    l1 = int.Parse(Console.ReadLine());
                    l2 = int.Parse(Console.ReadLine());
                    l3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    if (l1 > l2)
                    {
                        if (l1 > l3)
                        {
                            Console.WriteLine("The 1st Number {0} is the largest among three.",l1);
                        }
                        else
                        {
                            Console.WriteLine("The 3rd Number {0} is the largest among three.",l3);
                        }
                    }
                    else if (l2 > l3)
                        Console.WriteLine("The 2nd Number {0} is the largest among three.",l2);
                    else
                        Console.WriteLine("The 3rd Number {0} is the largest among three.",l3);
                    break;


                //15.Write a program in C# to find the smallest of five numbers accepted from the user.
                case "8":
                    int large, small;
                    int[] a = new int[50];
                    Console.WriteLine("Enter the size of Array");
                    int max = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine("Enter the array elements");
                    for (int size = 0; size < max; size++)
                    {
                        string m1 = Console.ReadLine();
                        a[size] = int.Parse(m1);
                    }                    
                    large = a[0];
                    small = a[0];
                    for (int size = 1; size < max; size++)
                    {
                        if (a[size] > large)
                            large = a[size];
                        else if (a[size] < small)
                            small = a[size];
                    }
                    Console.WriteLine("Largest element in the array is {0}", large);
                    Console.WriteLine("Smallest element in the array is {0}", small);

                    break;

                default:
                    break;
            }


        }
    }
}
