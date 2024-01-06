//You owe the credit card company an amount of M.The company charges you an interest of 1.5% per month on the unpaid balance. 
//You have decided close the card and pay off the debt by making a monthly payment of N rupee a month.

//Write a program that asks for the monthly payment, the program writes out the balance and total payments
//so far for every succeeding month until the balance is zero or less.

//Sample Input : 
//Enter the monthly payment: 100
//Sample Output: 
//Month: 1 balance: 915.0 total payments: 100.0 
//Month: 2 balance: 828.725 total payments: 200.0 
//Month: 3 balance: 741.155875 total payments: 300.0


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETTraining.Assignment
{
    class Assignment_24
    {        
        static void Main()
        {
            program Balance = new program();
            Balance.input();
            Balance.Calculation();
        }
    }
    class program
    {
        Decimal Amount;
        Decimal Amountpaid;
        decimal intrestAmount;
        decimal Intrest;
        decimal finalAmount;
        Decimal finalValue;
        public void input()
        {
            Console.WriteLine("enter the amount to be paid");
            Amount = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter the Intrest to be paid");
            Intrest = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter the amount paying");
            Amountpaid = int.Parse(Console.ReadLine());
        }
        public void Calculation()
        {
            int month = 0;
            decimal payment = Amountpaid;
            do
            {
                intrestAmount = (Amount * Intrest) / 100;
                finalAmount = (Amount - Amountpaid) + intrestAmount;
                Amount = finalAmount;
                month++;
                finalValue = Math.Round(finalAmount, 2);                
                Console.WriteLine("Month: " + month + "\t" + "balance: " + finalValue + "\t" + "total payments: " + payment);
                payment = payment + Amountpaid;
            }
            while (finalAmount >= 0);
        }
    }
}
