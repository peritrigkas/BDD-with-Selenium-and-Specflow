using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_with_Selenium_and_Specflow
{
    public class BaseClass
    {
        public int bas;

        private int base2;
        protected int base3;

        private void SetBase2(int par1)
        {
            base2 = par1;
        }

        protected void SetBase3(int par1)
        {
            base3 = par1;
        }
        public void GetBase23()
        {
            Console.WriteLine("Value : {0} :{1}", base2, base3);
        }

        public BaseClass(string par1)
        {
            Console.WriteLine("Base Class Cons : {0}", par1);
        }
        

        public BaseClass()
        {
           
        }
        
        public BaseClass(int par1)
        {
            Console.WriteLine("Base Class Cons : {0}" , par1);
        }
       

        public void GetInt()
        {
            bas = 10;
            Console.WriteLine("Value from Base : {0}", bas);
        }
    }

    public class DerivedClass : BaseClass
    {
        public DerivedClass(int par1) : base("Peri")
        {
            
            Console.WriteLine("Derived Class Cons : {0}", par1);
        }

        public void Show()
        {
            Console.WriteLine("From Child Class");
        }

        public void GetFromBaseClass()
        {
            //bas = 20;
            //GetInt();
            base.base3 = 20;
            base.SetBase3(23);
            base.GetBase23();
        }
        
    }

    
}
