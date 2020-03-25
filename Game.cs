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
        public bool canBuyLemonade = true;
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
                Console.WriteLine("Lemon Supply: " + player.inventory.lemons.Count);
                Console.WriteLine("Sugar Suppy: " + player.inventory.sugarCubes.Count);
                Console.WriteLine("Ice Cube Supply: " + player.inventory.iceCubes.Count);
                Console.WriteLine("Cup Supply: " + player.inventory.cups.Count);
                store.SellLemons(player);
                player.wallet.DisplayWallet();
                store.SellSugarCubes(player);
                player.wallet.DisplayWallet();
                store.SellIceCubes(player);
                player.wallet.DisplayWallet();
                store.SellCups(player);
                player.wallet.DisplayWallet();
                player.PickLemons();
                player.PickSugarCubes();
                player.PickIceCubes();
                player.ChangePricePerCup();
                MakePitcher();
                CreateCustomers();
                player.inventory.RemoveAllIceCubes();
                if(i == 1 || i == 3 || i == 5 || i == 7)
                {
                    player.inventory.RemoveAllLemons();
                }
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
            if(num <= chance && canBuyLemonade == true)
            {
                day.customer.willBuy = true;
                BuyLemonade();
                player.wallet.DisplayWallet();
                if(player.pitcher.cupsLeftInPitcher == 0)
                {
                    MakePitcher();
                }
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
            if(player.inventory.lemons.Count > player.recipe.amountOfLemons && player.inventory.sugarCubes.Count > player.recipe.amountOfSugarCubes &&
            player.inventory.iceCubes.Count > player.recipe.amountOfIceCubes && player.inventory.cups.Count > player.recipe.cupsPerPitcher)
            {
                player.inventory.RemoveLemonsFromInventory(player.recipe.amountOfLemons);
                player.inventory.RemoveSugarCubesFromInventory(player.recipe.amountOfSugarCubes);
                player.inventory.RemoveIceCubesFromInventory(player.recipe.amountOfIceCubes);
                player.inventory.RemoveCupsFromInventory(player.recipe.cupsPerPitcher);
                player.pitcher.cupsLeftInPitcher = 10;
            }
            else
            {
                Console.WriteLine("SOLD OUT");
                canBuyLemonade = false;
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
                player.pitcher.cupsLeftInPitcher--;
            }
            else
            {

            }
        }
    }
}
