using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    static class UserInterface
    {
        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }
        public static int ChooseRecipeRatio(string ingredient)
        {
            bool userInputIsAnInteger = false;
            int quantity = 0;
            while (!userInputIsAnInteger)
            {
                Console.WriteLine("How many " + ingredient + " would you like in your recipe?");
                Console.WriteLine("Please enter a positive integer");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantity);
            }
            return quantity;
        }
        public static double ChoosePricePerCup()
        {
            double maxPrice = .50;
            double price;
            {
                Console.WriteLine("What Price would you like each cup to be? The max prie is " + maxPrice);
                price = Convert.ToDouble(Console.ReadLine());
            }
            return price;
        }
    }
}
