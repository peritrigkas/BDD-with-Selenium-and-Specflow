using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_with_Selenium_and_Specflow
{
    
    class Triangle
    {
        public int triangle_base;
        public int triangle_height;

        // <access specifier> <name of the construcor> (<parameter>){}
        // 1. Constructor do not have return type
        // 2. Name of Constructor should be same as the class

        //public Triangle() //default constructor
        //{
        //    Console.WriteLine(" Constructor called");
        //}

        public Triangle(int a, int b) //parametrised constructor
        {
            Console.WriteLine(" Constructor called");
            triangle_base = a;
            triangle_height = b;
        }



        //<access modifirer> <return type> <name> (<parameter>){}

        public void GetArea()
        {
            double area = (0.5 * (triangle_base * triangle_height));
            Console.WriteLine("Area is : {0}", area);
        }

        public double GetTriangleArea()
        {
            double area = (0.5 * (triangle_base * triangle_height));
            return area;
        }

        public void SetValue(int par1, int par2)
        {
            triangle_base = par1;
            triangle_height = par2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //<class name> <obj name> = new < class name>
            Triangle triangle1 = new Triangle(10, 20);
            Triangle triangle2 = new Triangle(100,200);

            //triangle1.triangle_base = 10;
            //triangle1.triangle_height = 20;

            //triangle2.triangle_base = 100;
            //triangle2.triangle_height = 200;

            //triangle1.GetArea();
            //triangle2.GetArea();

            triangle1.SetValue(4, 10);
            triangle2.SetValue(100, 200);

            Console.WriteLine("The Triangle area is : {0}", triangle1.GetTriangleArea());
            Console.WriteLine("The Triangle area is : {0}", triangle2.GetTriangleArea());

            Console.ReadKey();
        }
           
    }
}
