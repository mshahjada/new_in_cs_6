using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace new_in_cs_6
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 4;
            //OldCustomer use for c# below 6.0
            //NewCustomer use for c# 6.0

            //-------------------read only auto property--------------------
            //Before C# 6.0
            OldCustomer oldCus = new OldCustomer();
            oldCus.set_customer_name("Barack", "Obama");
            Console.WriteLine("First Name: {0}, Last Name: {1}", oldCus.FirstName, oldCus.LastName);
            //After C# 6.0
            NewCustomer newCus = new NewCustomer("Donald", "Trump");
            Console.WriteLine($"First Name: {newCus.FirstName}, Last Name: {newCus.LastName}");

            //---------------Expression bodied member function--------------
            //Before C# 6.0
            Console.WriteLine("Full Name: {0}", oldCus.FullName);
            //After C# 6.0
            Console.WriteLine($"Full Name: {newCus.FullName}");


            //------------------Using static in namespace------------------
            //Before C# 6.0 => import all types from a namesspace
            Console.WriteLine("Sqrt of {0}: {1}", x, Math.Sqrt(x));
            //After C# 6.0 => import only member functionns from a namesspace
            Console.WriteLine($"Sqrt of {x}: {Sqrt(x)}");

            Console.ReadKey();

        }
    }
}
