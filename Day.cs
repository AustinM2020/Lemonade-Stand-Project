using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        Random random = new Random();
        public Weather weather;
        public List<Customer> customers;
        public Day()
        {
            weather = new Weather(random.Next(55, 96), new List<string> { "Sunny", "Rainy", "Overcast", "Hazy" });
        }
        public void PickWeather()
        {
            Console.WriteLine(weather.temp + " " + weather.conditions[random.Next(0, 4)]);
        }
    }
}
