using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Die
    {
        public int RollValue { get; set; } // property
        public void Roll() // Dice.Roll() method -- use Dice.Roll()
                 
        
        {
            List<int> RollValue = new List<int>() { 1, 2, 3, 4, 5, 6 }; // list sets the numbers on die
            Random rnd = new Random();
            int randIndex = rnd.Next(RollValue.Count);
            int random = RollValue[randIndex];

            Console.WriteLine(random); // prints the random value from the list
        }

            // deleted because they made no difference to randomising numbers
        }
    }

/*
 * The Die class should contain one property to hold the current die value,
 * and one method that rolls the die, returns an integer and takes no parameters.
 */

//Property
//Method

