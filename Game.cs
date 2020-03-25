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
            player.ChooseName();            
            for(int i = 1; i <= numberOfDays; i++)
            {
                day = new Day();
                Console.WriteLine(player.name + "'s lemonade stand");
                Console.WriteLine("Day: " + i);
                if(i > 1)
                {
                    player.inventory.RemoveAllIceCubes();
                }
                if (i == 3 || i == 5 || i == 7)
                {
                    player.inventory.RemoveAllLemons();
                }
                Console.WriteLine("-----------------------------------------------------------------------------");
                player.wallet.DisplayWallet();
                day.weather.PickWeather();
                Console.WriteLine("Lemon Supply: " + player.inventory.lemons.Count);
                Console.WriteLine("Sugar Supply: " + player.inventory.sugarCubes.Count);
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
                Console.WriteLine("----------------------------------------------------------------------------");
            }
            Console.WriteLine("GAME OVER!");
            player.wallet.DisplayFinalProfits();
        }
        public void TempResponse()
        {
            
            chance = 0;
            
            if(day.weather.temp > 90)
            {
                chance += 30;
            }
            else if(day.weather.temp > 80)
            {
                chance += 25;
            }
            else if (day.weather.temp > 70)
            {
                chance += 20;
            }
            else if(day.weather.temp > 60)
            {
                chance += 15;
            }
            else if(day.weather.temp > 55)
            {
                chance += 10;
            }
        }   
        public void CustomerResponse()
        {
            TempResponse();
            WeatherResponse();
            PriceResponse();
            RecipeResponse();
            num = random.Next(1, 51);
            if(num <= chance && canBuyLemonade == true)
            {
                day.customer.willBuy = true;
                BuyLemonade();
                player.wallet.DisplayWallet();
                RecipeCritics();
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
        public void PriceResponse()
        {
            if(chance >= 35)
            {
                if(player.recipe.pricePerCup <= .35)
                {
                    chance += 5;
                }
                else
                {
                    chance -= 8;
                    PriceCritics();
                }
            }
            else if (chance >= 30)
            {
                if (player.recipe.pricePerCup <= .30)
                {
                    chance += 5;
                }
                else
                {
                    chance -= 8;
                    PriceCritics();
                }
            }
            else if (chance >= 25)
            {
                if (player.recipe.pricePerCup <= .25)
                {
                    chance += 5;
                }
                else
                {
                    chance -= 8;
                    PriceCritics();
                }
            }
            else if (chance >= 20)
            {
                if (player.recipe.pricePerCup <= .20)
                {
                    chance += 5;
                }
                else
                {
                    chance -= 8;
                    PriceCritics();
                }
            }
            else if (chance >= 15)
            {
                if (player.recipe.pricePerCup <= .15)
                {
                    chance += 5;
                }
                else
                {
                    chance -= 8;
                    PriceCritics();
                }
            }
        }
        public void RecipeResponse()
        {
            if(player.recipe.amountOfLemons == player.recipe.bestAmountOfLemons && player.recipe.amountOfSugarCubes == player.recipe.bestAmountOfSugarCubes && player.recipe.amountOfIceCubes == player.recipe.bestAmountOfIceCubes)
            {
                chance += 5;
            }
            else
            {
                chance -= 5;
                
            }
        }
        public void MakePitcher()
        {
            if(player.inventory.lemons.Count >= player.recipe.amountOfLemons && player.inventory.sugarCubes.Count >= player.recipe.amountOfSugarCubes &&
            player.inventory.iceCubes.Count >= player.recipe.amountOfIceCubes && player.inventory.cups.Count >= player.recipe.cupsPerPitcher)
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
            if(day.weather.temp > 90 && canBuyLemonade == true)
            {
                for(int i = 0; i < random.Next(120, 170); i++)
                {
                    day.customer = new Customer();
                    CustomerResponse();
                    Console.WriteLine();
                }
            }
            else if(day.weather.temp > 80 && canBuyLemonade == true)
            {
                for (int i = 0; i < random.Next(100, 150); i++)
                {
                    day.customer= new Customer();
                    CustomerResponse();
                    Console.WriteLine();
                }
            }
            else if(day.weather.temp > 70 && canBuyLemonade == true)
            {
                for (int i = 0; i < random.Next(80, 120); i++)
                {
                    day.customer = new Customer();
                    CustomerResponse();
                    Console.WriteLine();
                }
            }
            else if(day.weather.temp > 60 && canBuyLemonade == true)
            {
                for(int i = 0; i < random.Next(60, 100); i++)
                {
                    day.customer = new Customer();
                    CustomerResponse();
                    Console.WriteLine();
                }
            }
            else if(day.weather.temp > 55 && canBuyLemonade == true)
            {
                for(int i = 0; i < random.Next(50, 80); i++)
                {
                    day.customer = new Customer();
                    CustomerResponse();
                    Console.WriteLine();
                }
            }
        }
        public void BuyLemonade()
        {
            double transactionGains = player.recipe.pricePerCup;
            player.wallet.AddMoneyForSales(transactionGains);
            player.pitcher.cupsLeftInPitcher--;
        }
        public void RecipeCritics()
        {
            num = random.Next(1, 16);
            if (player.recipe.amountOfLemons != player.recipe.bestAmountOfLemons && num <= 5)
            {
                Console.WriteLine(day.customer.name + " thinks your recipe needs more lemons");
            }
            else if (player.recipe.amountOfSugarCubes != player.recipe.bestAmountOfSugarCubes && num > 5 && num <= 10)
            {
                Console.WriteLine(day.customer.name + " thinks your recipe needs sugar");
            }
            else if (player.recipe.amountOfIceCubes != player.recipe.bestAmountOfIceCubes && num > 10 && num <= 15)
            {
                Console.WriteLine(day.customer.name + " thinks your recipe needs ice");
            }
            else
            {
                Console.WriteLine(day.customer.name + " Likes the Lemonade");
            }
        }
        public void PriceCritics()
        {
            int num = random.Next(1, 4);
            if(num == 2)
            {
                Console.WriteLine(day.customer.name + " thinks your lemonade is too expensive");
            }
        }
    }
}
