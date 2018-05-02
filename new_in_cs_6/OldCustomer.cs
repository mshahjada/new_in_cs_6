using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_in_cs_6
{
    class OldCustomer
    {

        //this declaration doesn't make sure it is really immutable
        //only enforces that properties doesn't modified from oustside of the class.
        //can change through using set_customer_name function
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public void set_customer_name(string f_name, string l_name)
        {
            FirstName = f_name;
            LastName = l_name;
        }
       
    }
}
