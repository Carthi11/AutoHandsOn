using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETTraining.Assignment
{
    class Assignment_7
    {
        static void Main()
        {
            //Your application should use a switch statement to determine the retail price for each product. 
            //It should calculate and display the total retail value of all products sold. 
            //Use a loop to determine when the application should stop  looping and display the final results.
            int product = -1, maxNoProd = 3;
            double quantity;
            double price1=0, price2=0, price3=0;
            double p1 = 22.5f;
            double p2 = 44.5f;
            double p3 = 9.98f;
            
            Console.WriteLine("Enter the total number of products to check price: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------------------------------");

            if (n> maxNoProd)
            {
                Console.WriteLine("Maximum number of products must be less than " + maxNoProd);
            }
            else
            {
                //quantity = int.Parse(Console.ReadLine());
                for (int i = 1; i <=n ; i++)
                {
                    Console.WriteLine("Enter the Product Numbers: ");
                    product = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    switch (product)
                    {
                        case 1:
                            Console.WriteLine("Enter the no of quantity for Product 1:");
                            quantity = double.Parse(Console.ReadLine());
                            price1 = quantity * p1;
                            Console.WriteLine("Total price of Product 1 is " + price1);
                            Console.WriteLine("--------------------------------------------------------------------------------");
                            break;

                        case 2:
                            Console.WriteLine("Enter the no of quantity for Product 2:");
                            quantity = double.Parse(Console.ReadLine());
                            price2 = quantity * p2;
                            Console.WriteLine("Total price of Product 2 is " + price2);
                            Console.WriteLine("--------------------------------------------------------------------------------");
                            break;
                        case 3:
                            Console.WriteLine("Enter the no of quantity for Product 3:");
                            quantity = double.Parse(Console.ReadLine());
                            price3 = quantity * p3;
                            Console.WriteLine("Total price of Product 3 is " + price3);
                            Console.WriteLine("--------------------------------------------------------------------------------");
                            break;

                        default:
                            Console.WriteLine("Invalid Input\n");
                            Console.WriteLine("--------------------------------------------------------------------------------");
                            break;

                    }
                }
            }
            
            double total = price1 + price2 + price3;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Total Sales: " + total);
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
            
        
    }
}
