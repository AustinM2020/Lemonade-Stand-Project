using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game 
    {
        Random random = new Random();
        Day day;
        Player player;
        Store store;
        public int chance;
        public int num;
        public Game()
        {
            day = new Day();
            player = new Player();
            store = new Store();
        }
        //Sunny>Overcast>Hazy>Rainy
        public void TempResponse()
        {
            day.weather.PickWeather();
            chance = 0;
            
            if(day.weather.temp > 90)
            {
                chance += 35;
            }
            else if(day.weather.temp > 80)
            {
                chance += 30;
            }
            else if (day.weather.temp > 70)
            {
                chance += 25;
            }
            else if(day.weather.temp > 60)
            {
                chance += 20;
            }
            else if(day.weather.temp > 55)
            {
                chance += 15;
            }
        }   
        public void CustomerResponse()
        {
            TempResponse();
            WeatherResponse();
            MoneyResponse();
            num = random.Next(1, 51);
            if(num <= chance)
            {
                day.customer.willBuy = true;
            }
            else
            {
                day.customer.willBuy= false;
            }
        }
        public void WeatherResponse()
        {
            if(day.weather.condition == "Sunny")
            {
                chance += 10;
            }
            else if (day.weather.condition == "Overcast")
            {
                chance += 8;
            }
            else if (day.weather.condition == "Hazy")
            {
                chance += 6;
            }
            else if (day.weather.condition == "Rainy")
            {
                chance += 4;
            }
        }       
        public void MoneyResponse()
        {
            if(chance >= 40)
            {
                if(player.recipe.pricePerCup <= .35)
                {
                    chance += 5;
                }
                else
                {
                    chance -= 8;
                }
            }
            else if (chance >= 35)
            {
                if (player.recipe.pricePerCup <= .30)
                {
                    chance += 5;
                }
                else
                {
                    chance -= 8;
                }
            }
            else if (chance >= 30)
            {
                if (player.recipe.pricePerCup <= .25)
                {
                    chance += 5;
                }
                else
                {
                    chance -= 8;
                }
            }
            else if (chance >= 25)
            {
                if (player.recipe.pricePerCup <= .20)
                {
                    chance += 5;
                }
                else
                {
                    chance -= 8;
                }
            }
            else if (chance >= 20)
            {
                if (player.recipe.pricePerCup <= .15)
                {
                    chance += 5;
                }
                else
                {
                    chance -= 8;
                }
            }
        }
        public void Mehtod()
        {
            
        }  
    }
}
