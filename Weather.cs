using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        public int temp;       
        public List<string> conditions;
        
        public Weather(int temp, List<string> conditions)
        {
            this.temp = temp;
            this.conditions = conditions;
            
        }
           
    }
}
