using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
  
        public int Initialroll()
        {
            // Instantiation creates 3 die objects (of class Die)
            Die dice1 = new Die();
            Die dice2 = new Die();
            Die dice3 = new Die();

            dice1.Roll();
            dice2.Roll();
            dice3.Roll();


            // Each integer rolled is added to its own variable
            int x = dice1.GetRollValue();
            int y = dice2.GetRollValue();
            int z = dice3.GetRollValue();

            Console.WriteLine($"\nOne dice rolled a " + x);

            Console.WriteLine($"\nOne dice rolled a " + y);

            Console.WriteLine($"\nOne dice rolled a "+ z);

            // Each of these variables are summed up and printed out
            int sum = x + y + z;
            Console.WriteLine($"The sum of the 3 rolls is " + sum);

            return sum;
        }

        public void MoreRolls()
        {
            // additional task: asks user how many rolls they would like and sums them up in the Game class
            Console.WriteLine("Would you like to roll again?");
            Console.WriteLine("If so, enter how many times you would like to roll the dice:");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1)
            {

                int[] array = new int[number];
                for (int i = 0; i <= number - 1; i++)
                {
                    Die CurrentDie = new Die();
                    int diceroll = CurrentDie.Roll();
                    Console.WriteLine($"One dice rolled a {diceroll}.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Please input an integer, greater than 0.");
                Console.ReadKey();
                MoreRolls();
            }
            Console.ReadKey();
        }
    }
}