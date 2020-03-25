using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;

        // constructor (SPAWNER)
        public Player()
        {
            //inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
            inventory = new Inventory();
        }

        // member methods (CAN DO)

        public void PickLemons()
        {
            recipe.amountOfLemons = UserInterface.ChooseRecipeRatio("lemons");
        }
        public void PickSugarCubes()
        {
            recipe.amountOfSugarCubes = UserInterface.ChooseRecipeRatio("sugar");
                
        }
        public void PickIceCubes()
        {
            recipe.amountOfIceCubes = UserInterface.ChooseRecipeRatio("ice cubes");            
        }
        public double ChangePricePerCup()
        {
            recipe.pricePerCup = UserInterface.ChoosePricePerCup();
            return recipe.pricePerCup;
        }
    }
}
