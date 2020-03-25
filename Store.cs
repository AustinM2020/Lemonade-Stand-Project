using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Store
    {
        // member variables (HAS A)
        private double pricePerLemon;
        private double pricePerSugarCube;
        private double pricePerIceCube;
        private double pricePerCup;

        // constructor (SPAWNER)
        public Store()
        {
            pricePerLemon = .06;
            pricePerSugarCube = .07;
            pricePerIceCube = .01;
            pricePerCup = .03;
        }

        // member methods (CAN DO)
        public void SellLemons(Player player)
        {
            Console.WriteLine("The price per lemon: " + pricePerLemon);
            int lemonsToPurchase = UserInterface.GetNumberOfItems("lemons");
            double transactionAmount = CalculateTransactionAmount(lemonsToPurchase, pricePerLemon);
            if(player.wallet.Money >= transactionAmount)
            {
                player.wallet.PayMoneyForItems(transactionAmount);
                player.inventory.AddLemonsToInventory(lemonsToPurchase);
            }
            else
            {
                Console.WriteLine("Not enough money for purchase!");
                SellLemons(player);
            }
        }

        public void SellSugarCubes(Player player)
        {
            Console.WriteLine("The price per sugar cube: " + pricePerSugarCube);
            int sugarToPurchase = UserInterface.GetNumberOfItems("sugar cubes");
            double transactionAmount = CalculateTransactionAmount(sugarToPurchase, pricePerSugarCube);
            if(player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddSugarCubesToInventory(sugarToPurchase);
            }
            else
            {
                Console.WriteLine("Not enough money for purchase!");
                SellSugarCubes(player);
            }
        }

        public void SellIceCubes(Player player)
        {
            Console.WriteLine("The price per ice cube: " + pricePerIceCube);
            int iceCubesToPurchase = UserInterface.GetNumberOfItems("ice cubes");
            double transactionAmount = CalculateTransactionAmount(iceCubesToPurchase, pricePerIceCube);
            if(player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddIceCubesToInventory(iceCubesToPurchase);
            }
            else
            {
                Console.WriteLine("Not enough money for purchase!");
                SellIceCubes(player);
            }
        }

        public void SellCups(Player player)
        {
            Console.WriteLine("The price per cup: " + pricePerCup);
            int cupsToPurchase = UserInterface.GetNumberOfItems("cups");
            double transactionAmount = CalculateTransactionAmount(cupsToPurchase, pricePerCup);
            if(player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddCupsToInventory(cupsToPurchase);
            }
            else
            {
                Console.WriteLine("Not enough money for purchase!");
                SellCups(player);
            }
        }

        private double CalculateTransactionAmount(int itemCount, double itemPricePerUnit)
        {
            double transactionAmount = itemCount * itemPricePerUnit;
            return transactionAmount;
        }

        private void PerformTransaction(Wallet wallet, double transactionAmount)
        {
            wallet.PayMoneyForItems(transactionAmount);
        }
    }
}
