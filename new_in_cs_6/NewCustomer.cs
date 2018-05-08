using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_in_cs_6
{
    public class NewCustomer
    {
        //read only auto property make sure it's immutable
        //only can change through constructor
        public NewCustomer(string f_name, string l_name)
        {
            FirstName = f_name;
            LastName = l_name;
        }
        public string FirstName { get; } = string.Empty; //property initizlizer
        public string LastName { get; } = string.Empty;

        public string Address { get; set; }

        //Expression bodied member function
        public string FullName => $"{FirstName} {LastName}";

        public double GetTotalAmount() => 60*3;
    }
}
