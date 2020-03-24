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
            int numberOfLemons = UserInterface.ChooseRecipeRatio("lemons");
            recipe.amountOfLemons = numberOfLemons;
        }
        public void PickSugarCubes()
        {
            int numberOfSugarCubes = UserInterface.ChooseRecipeRatio("sugar cubes");
            recipe.amountOfSugarCubes = numberOfSugarCubes;
        }
        public void PickIceCubes()
        {
            int numberOfIceCubes = UserInterface.ChooseRecipeRatio("ice cubes");
            recipe.amountOfSugarCubes = numberOfIceCubes;
        }
        public void PickCups()
        {
            int numberOfCups = UserInterface.ChooseRecipeRatio("cups");
            recipe.amountOfCups = numberOfCups;
        }
        public double ChangePricePerCup()
        {
            recipe.pricePerCup = UserInterface.ChoosePricePerCup();
            return recipe.pricePerCup;
        }
    }
}
