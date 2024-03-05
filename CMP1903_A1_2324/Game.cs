using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Game
    {
        static void Main(string[] args) // Entry point is defined in the game class, to allow access to the Die class
        {
            // Instantiation creates 3 die objects (of class Die)
            Die dice1 = new Die();
            Die dice2 = new Die();
            Die dice3 = new Die();

            // Each integer rolled is added to its own variable
            int x = dice1.Roll();
            Console.ReadKey();
            int y = dice2.Roll();
            Console.ReadKey();
            int z = dice3.Roll();
            Console.ReadKey();

            // Each of these variables are summed up and printed out
            int sum = x + y + z;
            Console.WriteLine($"The sum of the 3 rolls is " + sum);
        }
    }
}