using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Day
    {
        Random random = new Random();
        public Weather weather;
        public Customer customer;
        public Day()
        {
            weather = new Weather();
            customer = new Customer();
        }
        
    }
}