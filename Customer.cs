using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        public string name;
        List<string> names;
        public Customer(string name)
        {
            this.name = name;
            names.Add("Mike");
            names.Add("Finn");
            names.Add("Sean");
            names.Add("Jamie");
            names.Add("Katie");
            names.Add("Aubrun");       
        }
    }
}
