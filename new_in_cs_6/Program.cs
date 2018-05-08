using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.String;

namespace new_in_cs_6
{
    class Program
    {
        public static void getExpresion()
        {
            NewCustomer nc1 = new NewCustomer("", "");

            try
            {
                if (IsNullOrWhiteSpace(nc1.Address))
                    throw new ArgumentException(message: "No address found", paramName: nameof(nc1.Address));
            }
            catch(ArgumentException aex)
            {
                Console.WriteLine(aex.Message);
            }

        }

        public static void Extension_Method_In_Collection_Initializer()
        {

        }

        static void Main(string[] args)
        {

            int x = 4;
            //OldCustomer use for c# below 6.0
            //NewCustomer use for c# 6.0
            string feature = string.Empty;
            feature = "-------------------read only auto property--------------------";
            Console.WriteLine($"{feature}");
            //Before C# 6.0
            OldCustomer oldCus = new OldCustomer();
            oldCus.set_customer_name("Barack", "Obama");
            Console.WriteLine("First Name: {0}, Last Name: {1}", oldCus.FirstName, oldCus.LastName);
            //After C# 6.0
            NewCustomer newCus = new NewCustomer("Donald", "Trump");
            Console.WriteLine($"First Name: {newCus.FirstName}, Last Name: {newCus.LastName}");

            feature = "\n---------------Expression bodied member function--------------";
            Console.WriteLine($"{feature}");
            //Before C# 6.0
            Console.WriteLine("Full Name: {0}", oldCus.FullName);
            //After C# 6.0
            Console.WriteLine($"Full Name: {newCus.FullName}");


            feature = "\n------------------Using static in namespace------------------";
            Console.WriteLine($"{feature}");
            //Before C# 6.0 => import all types from a namesspace
            Console.WriteLine("Sqrt of {0}: {1}", x, Math.Sqrt(x));
            //After C# 6.0 => import only member functionns from a namesspace
            Console.WriteLine($"Sqrt of {x}: {Sqrt(x)}");



            feature = "\n-------------- Null-conditional operators---------------------";
            Console.WriteLine($"{feature}");
            NewCustomer nc1 = new NewCustomer("", "");

            //Before C# 6.0
            if (nc1 != null)
            {
                var result = nc1.Address ?? "Newly Set";
                Console.WriteLine("Value: {0}", result);
            }

            //After C# 6.0
            var res = nc1?.Address ?? "Hello";
            Console.WriteLine($"Value: {res}");



            feature = "\n----------------String Interpolation---------------------";
            Console.WriteLine($"{feature}");

            Console.WriteLine($"Customer Name: {nc1.FullName}, Total Amount: {nc1.GetTotalAmount()}");


            feature = "\n----------------Expression---------------------";
            Console.WriteLine($"{feature}");
            getExpresion();


            feature = "\n----------------Index Initializer---------------------";
            Console.WriteLine($"{feature}");

            //Before C# 6.0
            List<string> messages = new List<string>{
                "Hello - 120",
                "Hello - 90",
                "Hello - 130"
            };

            //After C# 6.0
            Dictionary<int, string> dic = new Dictionary<int, string>
            {
                [120] = "Hello - 120",
                [90] = "Hello - 90",
                [130] = "Hello - 130"
            };

            //Console.WriteLine(dic[120]);

            foreach (var item in dic)
            {
                Console.WriteLine($"Index: {item.Key}, Value: {item.Value}");
            }



            feature = "\n----------------Collection Initializer---------------------";
            Console.WriteLine($"{feature}");
            var trans = new Sales()
            {
                new NewCustomer("James", "Wodman"),
                new NewCustomer("Radiq", "Fables"),
                new NewCustomer("Doz", "Huber")
            };


            Console.ReadKey();




        }
    }
}
