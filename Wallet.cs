using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Wallet
    {
        private double money;

        public double Money
        {
            get
            {
                return money;
            }
        }

        public Wallet()
        {
            money = 20.00;
        }

        public void PayMoneyForItems(double transactionAmount)
        {
            money -= transactionAmount;
        }
        public void AddMoneyForSales(double transactionGains)
        {
            money += transactionGains;
        }
        public void DisplayWallet()
        {
            Console.WriteLine("Curremt wallet ammount: $" + money);
        }
        public void DisplayFinalProfits()
        {
            Console.WriteLine("Final Profits: " + (money - 20));
        }
    }
}
