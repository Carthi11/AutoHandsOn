using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETTraining.Assignment
{
    class Assignment_17to20
    {
        static void Main()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Enter the corresponding number to perfom an action : ");
            Console.WriteLine("1. Find the length of the Word");
            Console.WriteLine("2. Display reverse of the word.");
            Console.WriteLine("3. Check whether the entered words are same ot not.");
            Console.WriteLine("4. Given word is a palindrome or not.");
            Console.WriteLine("--------------------------------------------------------------------------------");
            string number = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            int p = 0;
            switch (number)
            {
                //17.	Write a program in C# to accept a word from the user and display the length of it.
                case "1":
                    Console.WriteLine("Enter the name/word to find the length: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    int Length = name.Length;
                    Console.WriteLine("The name " + name + " contains " + Length + " letters.");
                    break;

                //18.	Write a program in C# to accept a word from the user and display the reverse of it.
                case "2":
                    Console.WriteLine("Enter the name/word to reverse: ");
                    String Word = Console.ReadLine();
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    char[] arr = Word.ToCharArray();
                    Array.Reverse(arr);
                    Console.WriteLine(arr);
                    //Console.WriteLine(string.Join(" ", text.Split(' ').Reverse()));
                    break;

                //19.	Write a program in C# to accept two words from user and find out if they are same.

                case "3":                          
                    int flg = 0,same=0;                  
                    Console.WriteLine("Compare two string whether they are equal or not :");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Enter the 1st string : ");
                    String str1 = Console.ReadLine();
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.Write("Enter the 2nd string : ");
                    String str2 = Console.ReadLine();
                    int l1 = str1.Length;
                    int l2 = str2.Length;
                    /*compare checking when they are equal in length*/
                    if (l1 == l2)
                    {
                        for (int i = 0; i < l1; i++)
                        {
                            if (str1[i] != str2[i])
                            {
                                same = 1;
                                i = l1;
                            }
                        }
                    }                    
                    if (l1 == l2)
                    {
                        if (flg == 0)
                        {
                            if (same == 0)
                                //Console.Write("\nThe length of both strings are equal");
                                Console.WriteLine("The length of both strings are equal and also, both strings are same.");
                            else
                                Console.WriteLine("The length of both strings are equal but they are not same.");
                        }
                    }
                    else                    
                    Console.WriteLine("The length of both strings are NOT equal");
                    
                    break;

                //20.	Write a program in C# to accept a word and to find out whether the given word is a palindrome or not.
                case "4":
                    Console.WriteLine("Enter a string to find its Palindrome or NOT:");
                    String original = Console.ReadLine();
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    String reversed = new string(original.Reverse().ToArray());
                    if (original == reversed)
                        Console.WriteLine("Palindrome");
                    else
                        Console.WriteLine("Not a Palindrome");
                    break;
                default:
                    break;

            }
        }

    }
}
