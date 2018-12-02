using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_with_Selenium_and_Specflow
{
    public class BaseClass
    {
        public BaseClass(int par1)
        {
            Console.WriteLine("Base Class Cons : {0}" , par1);
        }
        protected int bas;

        public void GetInt()
        {
            bas = 10;
            Console.WriteLine("Value from Base : {0}", bas);
        }
    }

    public class DerivedClass : BaseClass
    {
        public DerivedClass(int par1) : base(par1)
        {
            par1 = 3;
            Console.WriteLine("Derived Class Cons : {0}", par1);
        }

        public void Show()
        {
            Console.WriteLine("From Child Class");
        }

        public void GetFromBaseClass()
        {
            bas = 20;
            GetInt();
        }
        
    }

    
}
