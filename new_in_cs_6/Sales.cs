using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_in_cs_6
{
    public class Sales : IEnumerable<NewCustomer>
    {
        private List<NewCustomer> customers = new List<NewCustomer>();

        public void Add_Customer(NewCustomer nc)
        {
            customers.Add(nc);
        }

        public IEnumerator<NewCustomer> GetEnumerator()
        {
            return ((IEnumerable<NewCustomer>)customers).GetEnumerator();
        }

 
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<NewCustomer>)customers).GetEnumerator();
        }
    }


    public static class SaleExtend
    {
        public static void Add(this Sales e, NewCustomer s) => e.Add_Customer(s);
    }
}
