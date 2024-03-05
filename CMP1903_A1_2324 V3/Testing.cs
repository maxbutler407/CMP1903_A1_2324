using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public void TestDieClass()
        {
            // Creates an instance of the Die class
            Die die = new Die();

            // Tests the Roll() method to check for valid return types
            Console.WriteLine("Testing Roll method...");

            Debug.Assert(die.Roll() >= 1 && die.Roll()<= 6, "Value should only be an integer in the range of 1 to 6.");
        }

        public void TestGameClass()
        {
            // Create an instance of the Game class
            Game game = new Game();

            // Test ExecuteFurtherDiceRolls method to check for valid return types
            Console.WriteLine("Testing the sum variable...");

            // Assertions ensure sum != 0 or <= 19, as that would mean a dice roll was not an integer not in the range 
            Debug.Assert(game.Initialroll() >= 3, "The 3 dice rolls cannot sum to be less than 3.");
            Debug.Assert(game.Initialroll() <= 19, "The 3 dice rolls cannot sum to be 19 and over.");
        }
    }
}