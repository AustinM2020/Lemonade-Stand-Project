using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game 
    {
        Day day;
        public Game()
        {
            day = new Day();
        }
        //Sunny>Overcast>Hazy>Rainy
        public void CustomerResponse()
        {
            int chance = 0;
            
            if(day.weather.temp > 90)
            {
                chance += 45;
                if (day.weather.condition == "Sunny")
                {

                }
                else if (day.weather.condition == "Overcast")
                {

                }
                else if (day.weather.condition == "Hazy")
                {

                }
                else if (day.weather.condition == "Rainy")
                {

                }
            }
            else if(day.weather.temp > 80)
            {
                chance += 45;
                if (day.weather.condition == "Sunny")
                {

                }
                else if (day.weather.condition == "Overcast")
                {

                }
                else if (day.weather.condition == "Hazy")
                {

                }
                else if (day.weather.condition == "Rainy")
                {

                }
            }
            else if (day.weather.temp > 70)
            {
                chance += 45;
                if (day.weather.condition == "Sunny")
                {

                }
                else if (day.weather.condition == "Overcast")
                {

                }
                else if (day.weather.condition == "Hazy")
                {

                }
                else if (day.weather.condition == "Rainy")
                {

                }
            }
            else if(day.weather.temp > 60)
            {
                chance += 45;
                if (day.weather.condition == "Sunny")
                {

                }
                else if (day.weather.condition == "Overcast")
                {

                }
                else if (day.weather.condition == "Hazy")
                {

                }
                else if (day.weather.condition == "Rainy")
                {

                }
            }
            else if(day.weather.temp > 55)
            {
                chance += 45;
                if (day.weather.condition == "Sunny")
                {

                }
                else if (day.weather.condition == "Overcast")
                {

                }
                else if (day.weather.condition == "Hazy")
                {

                }
                else if (day.weather.condition == "Rainy")
                {

                }
            }
        }   
    }
}
