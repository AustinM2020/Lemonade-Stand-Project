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
        int numberOfDays = 7;
        public int num;
        public Game()
        {
            player = new Player();
            store = new Store();
        }
        //Sunny>Overcast>Hazy>Rainy
        public void RunGame()
        {
            for(int i = 0; i <= numberOfDays; i++)
            {
                day = new Day();
                player.wallet.DisplayWallet();
                day.weather.PickWeather();
                store.SellLemons(player);
                store.SellSugarCubes(player);
                store.SellIceCubes(player);
                store.SellCups(player);
                player.PickLemons();
                player.PickSugarCubes();
                player.PickIceCubes();
                player.ChangePricePerCup();
                CreateCustomers();
            }
        }
        public void TempResponse()
        {
            
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
                BuyLemonade();
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
        public void MakePitcher()
        {
            while (player.recipe.cupsPerPitcher == 0 && inventory.lemons.Count > player.recipe.amountOfLemons && inventory.sugarCubes.Count > player.recipe.amountOfSugarCubes &&
            inventory.iceCubes.Count > player.recipe.amountOfIceCubes && inventory.cups.Count > player.recipe.cupsPerPitcher)
            {
                inventory.RemoveLemonsFromInventory(player.recipe = new Recipe());
                inventory.RemoveSugarCubesFromInventory(player.recipe = new Recipe());
                inventory.RemoveIceCubesFromInventory(player.recipe = new Recipe());
                inventory.RemoveCupsFromInventory(player.recipe = new Recipe());
            }
           
        }  
        public void CreateCustomers()
        {
            if(day.weather.temp > 90)
            {
                for(int i = 0; i < random.Next(120, 170); i++)
                {
                    Customer customer = new Customer();
                    CustomerResponse();
                }
            }
            else if(day.weather.temp > 80)
            {
                for (int i = 0; i < random.Next(100, 150); i++)
                {
                    Customer customer = new Customer();
                    CustomerResponse();
                }
            }
            else if(day.weather.temp > 70)
            {
                for (int i = 0; i < random.Next(80, 120); i++)
                {
                    Customer customer = new Customer();
                    CustomerResponse();
                }
            }
            else if(day.weather.temp > 60)
            {
                for(int i = 0; i < random.Next(60, 100); i++)
                {
                    Customer customer = new Customer();
                    CustomerResponse();
                }
            }
            else if(day.weather.temp > 55)
            {
                for(int i = 0; i < random.Next(50, 80); i++)
                {
                    Customer customer = new Customer();
                    CustomerResponse();
                }
            }
        }
        public void BuyLemonade()
        {
            if (day.customer.willBuy == true)
            {
                double transactionGains = player.recipe.pricePerCup;
                player.wallet.AddMoneyForSales(transactionGains);
            }
            else
            {

            }
        }
    }
}
