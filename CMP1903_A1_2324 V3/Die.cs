using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
     //   TestDieClass();

        private int dicevalue = 0; // {  get; set; } // dicevalue property is used to store the roll value

        private static Random random = new Random(); // Creates random object using built-in Random class

        // this block programs the Roll() method
        public int Roll()
        {
  
            int diceroll = random.Next(1, 7); // Picks a random integer (1-6) from a list using the random object
   
            // Unused method was designed for the additional task, but code is not finished
            //MoreRolls();

  
            dicevalue = diceroll; // Assigns a value to the dicevalue property

            return dicevalue;
        }

        public int GetRollValue()
        {
            return dicevalue;
        }

    }
}