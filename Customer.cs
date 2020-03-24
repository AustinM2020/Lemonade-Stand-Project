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
        public Customer(string name)
        {
            this.name = name;
            names = new List<string>() { "Mike", "Finn", "Sean", "Jamie", "Katie", "Auburn", "Charles", "King", 
                "Christine", "Isaiah", "Chris", "Jack", "Cj", "Frank", "Aaron", "Lynda", "Jess"  };
            
        }

        public string GenerateCustomer()
        {
            name = names[random.Next(0, 5)];
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
