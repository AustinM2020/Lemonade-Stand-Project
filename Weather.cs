using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Weather
    {
        Random random = new Random();
        public int temp;
        public string condition;
        List<string> forcasts;    
        public Weather()
        {          
            forcasts = new List<string>() { "Sunny", "Rainy", "Overcast", "Hazy" };
            this.condition = forcasts[random.Next(0, 4)];
        }
        public void PickWeather()
        {
            temp = random.Next(55, 96);
            Console.WriteLine(temp + "°F " + condition);
        }
    }
}
