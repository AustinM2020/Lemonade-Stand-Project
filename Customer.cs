using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Customer
    {
        Random random = new Random();
        public bool willBuy;
        
        public string name;
        List<string> names;
        public Customer()
        {
            names = new List<string>() { "Mike", "Finn", "Sean", "Jamie", "Katie", "Auburn", "Charles", "King", 
                "Christine", "Isaiah", "Chris", "Jack", "Cj", "Frank", "Aaron", "Lynda", "Jess"  };
            name = names[random.Next(0, 5)];
        }

        public string GenerateCustomer()
        {
            return name;
        }
        public void BuyLemonade(Recipe recipe, Wallet wallet)
        {
            if(willBuy == true)
            {
                wallet.Money += recipe.pricePerCup;
            }
        }
        
    }
}
