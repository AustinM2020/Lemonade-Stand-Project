using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Recipe
    {
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public int amountOfCups;
        public double pricePerCup;
        public int cupsPerPitcher;
        
        public Recipe()
        {
            pricePerCup = .25;
            cupsPerPitcher = 10;
        }
    
        
    }
}
