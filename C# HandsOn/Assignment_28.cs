//You need to calculate area of different shapes, such as Circle, Rectangle and Triangle.
//All the shapes are represented by different entities, whereas all the entities have one method in common to calculate the area of the shapes.
//But, the fields of those entities are not same. 
//So, create three different classes to represent the three shapes and provide fields to those classes.
//Provide a common method to calculate the area of the shapes.The signature of the method is as follows public void CalculateArea(). 
//Do not use WriteLine() method of Console class in the method code to display the Calculated Area


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETTraining.Assignment
{
    class Assignment_28
    {
        public float length, breadth, radius, side, hieght, breadthfortriangle;
        static void Main(string[] args)
        {
            Assignment_28 Area = new Assignment_28();
            Area.Rectangle();
            Area.Circle();
            Area.Square();
            Area.Triangle();
            Console.ReadKey();
        }
        public void Rectangle()
        {
            Console.WriteLine("Enter the Length for Rectangle");
            length = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth for Rectangle");
            breadth = float.Parse(Console.ReadLine());
            Console.WriteLine("Area of rectangle is :{0}", length * breadth);
        }
        public void Circle()
        {
            Console.WriteLine("Enter the Radius of the Circle");
            radius = float.Parse(Console.ReadLine());
            Console.WriteLine("Area of Circle is:{0}", 3.14 * radius * radius);
        }
        public void Square()
        {
            Console.WriteLine("Enter the side of a square");
            side = float.Parse(Console.ReadLine());
            Console.WriteLine("Area of Square is:{0}", side * side);
        }
        public void Triangle()
        {
            Console.WriteLine("Enter the Breadth for Triangle ");
            breadthfortriangle = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Hieght for Triangle ");
            hieght = float.Parse(Console.ReadLine());
            Console.WriteLine("Area of Triangle is:{0}", (breadthfortriangle * hieght) / 2);
        }
    }
}
