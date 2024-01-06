//Names are stored in an array in the pattern: last name first pattern[lastName, firstName]. 
//For example given the name “Sharma, Rakesh”, “Rakesh” is first name and “Sharma” is last name.
//Complete the method provided to return the collection of strings sorted based on their first name. 
//Method: 
//public static String[] SortByFirstName(string[] names)

//Sample Input: 
//{“Sharma, Rakesh”, “Patil, Par-thiv”, “Gowda, Anil”, 
//“Prasad, Vishnu”, “Khan, Amir”}

//Required Output:
//“Khan, Amir”, “Gowda, Anil”, “Patil, Parthiv”, “Sharma, Rakesh”, “Prasad, Vishnu”

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETTraining.Assignment
{
    class Assignment_25
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of element to be enter : ");
            int no = int.Parse(Console.ReadLine());
            String[] names = new String[no];
            Console.WriteLine("Enter " + no + " name with surname seprated with \",\" ");
            for (int i = 0; i < no; i++)
            {
                names[i] = Console.ReadLine();
            }
            names = SortByLastName(names);
            Console.WriteLine("\n\nName after sorted is : \n\n");
            foreach (String item in names)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }

        public static String[] SortByLastName(string[] names)
        {
            Array.Sort(names, delegate (string str, string str1)
            {
                string fstName1, fstName2;
                fstName1 = str.Substring(str.IndexOf(','), str.Length - str.IndexOf(','));
                fstName2 = str1.Substring(str1.IndexOf(','), str1.Length - str1.IndexOf(','));
                return fstName1.CompareTo(fstName2) > 0 ? 1 : -1;
            });
            return names;
        }
    }
}
