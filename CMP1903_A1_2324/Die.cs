using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{ 
    public class Die
    {
        TestDieClass();

        public int dicevalue {  get; set; } // dicevalue property is used to store the roll value

        // this block programs the Roll() method
        public int Roll()
        {
            Random random = new Random(); // Creates random object using built-in Random class

            int diceroll = random.Next(1, 7); // Picks a random integer (1-6) from a list using the random object
    

            Console.WriteLine($"\nOne dice rolled a {diceroll}"); // Prints the random value from the list


            // Unused method was designed for the additional task, but code is not finished
            //MoreRolls();

            void MoreRolls()
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
                         Roll();
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
            dicevalue = diceroll; // Assigns a value to the dicevalue property
            return dicevalue;
        }
    }
}