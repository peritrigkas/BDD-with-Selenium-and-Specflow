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

        public static int staticint;

        // Static methode rules :
        // 1. can access only static methods
        // 2. can access only static variables

        public static void SetStaticValue(int par1)
        {
            staticint = par1;
        }

        public static void GetStaticValue()
        {
            // SetValue() cannot be accessed because its not static
            SetStaticValue(120);
            Console.WriteLine("Static Value is : {0}", staticint);
        }


        public void SetValue(int par1)
        {
            staticint = par1;
        }

        public void GetStatic()
        {
            Console.WriteLine("Static Value is : {0}", staticint);
        }

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
    public interface INterface1
    {
        void Display(string str);
        void Display(string str1, string str2);
    }

    public interface INterface2
    {
        void Display(string str);
        void Display(string str1, string str2);
    }

    public class DerivedClassOne : INterface1, INterface2
    {
        public void Display(string str)
        {
            Console.WriteLine(str);
        }

        public void Display(string str1, string str2)
        {
            Console.WriteLine("{0} : {1}", str1, str2);
        }
    }

    class Program
    {
              static void Main(string[] args)
        {
            //<class name> <obj name> = new < class name>
            //Triangle triangle1 = new Triangle(10, 20);
            //Triangle triangle2 = new Triangle(100,200);
                       
            //triangle1.triangle_base = 10;
            //triangle1.triangle_height = 20;

            //triangle2.triangle_base = 100;
            //triangle2.triangle_height = 200;

            //triangle1.GetArea();
            //triangle2.GetArea();

            //triangle1.SetValue(4, 10);
            //triangle2.SetValue(100, 200);

            //triangle1.SetValue(123);

            //Triangle.staticint = 10;
            //triangle2.GetStatic();

            //Triangle.GetStaticValue();

            ////// Inheritance ///////////

            DerivedClass derived = new DerivedClass(20); // Constructor example
                                                         //derived.Show(); // 

            //derived.GetInt();

            ////// Inheritance ///////////
            //     Interface    //
            INterface1 obj1 = new DerivedClassOne();

            obj1.Display("pERI");
            obj1.Display("paok", "chris");

            INterface2 obj2 = new DerivedClassOne();

            derived.GetFromBaseClass();
            //Console.WriteLine("The Triangle area is : {0}", triangle1.GetTriangleArea());
            //Console.WriteLine("The Triangle area is : {0}", triangle2.GetTriangleArea());

            Console.ReadKey();
        }
           
    }
}
