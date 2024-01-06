//1.You deposit Rs 1000.00 in the bank account at 5% annual compound interest.
//The interest is paid once at the end of the year.
//What if you are interested in earning more than 100000? How long will it take to reach this mark?

//Sample Output:
//Year Interest for the year   End of the year amount
///1 	1000*0.05=50 	1050.00 
///2 	1050*0.05=52.5 	1102.50 
///3 	1102.50*0.05=55.125 	1157.625 

//2. Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETTraining.Assignment
{
    class Assignment_23
    {
        int initialAmount, targetAmount;
        decimal interestRate;
        public void getvalues()
        {
            Console.Write("Enter the initial deposit amount : ");
            initialAmount = int.Parse(Console.ReadLine());

            Console.Write("Enter the target amount : ");
            targetAmount = int.Parse(Console.ReadLine());

            Console.Write("Annual compound interest rate : ");
            interestRate = decimal.Parse(Console.ReadLine()) / 100;
        }
        static void Main()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Enter the corresponding number to perfom an action : ");
            Console.WriteLine("1. Display 2D matrix of of 3*3 Array:  ");
            Console.WriteLine("2. Display the interest amount and number of year to reach the mark: ");
            Console.WriteLine("--------------------------------------------------------------------------------");
            string number = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Assignment_23 out2 = new Assignment_23();
            Program out1 = new Program();
            switch (number)
            {

                case "1":
                    out1.matrix();
                    break;

                case "2":
                    out2.getvalues();
                    decimal finalAmount = out1.calculateinterest(out2.initialAmount, out2.targetAmount, out2.interestRate);
                    break;


            }

        }

    }

    class Program
    {
        public void matrix()
        {
            int i, j;
            int[,] arr1 = new int[3, 3];

            Console.WriteLine("Read a 2D array of size 3x3 and print the matrix :");
            Console.WriteLine("------------------------------------------------------");
            /* Stored values into the array*/
            Console.WriteLine("Input elements in the matrix :");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");
        }

        public decimal calculateinterest(decimal depositAmount, decimal requiredAmount, decimal rateOfCompundInterest)
        {
            double time = 0;
            decimal amount = depositAmount;
            decimal ci = 0;
            Console.WriteLine("Year" + "\t" + "Interest for the year " + "\t" + "End of the year amount \n");
            while (amount <= requiredAmount)
            {
                time++;
                ci = amount * rateOfCompundInterest;
                amount = amount + ci;
                Console.WriteLine(time + "\t" + amount + "*" + rateOfCompundInterest + "=" + ci + "\t\t" + amount);
            }
            return amount;
        }
        
    }

    
}
