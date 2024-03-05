using CMP1903_A1_2324;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool Testing = true;

            // Simple if else statement that will either run the game or test the methods depending on the above 'Testing' bool
            if (!Testing)
            {
                RunGame();
            }
            else
            {
                TestMethods();
            }

            // Function to create a testing object and run its methods 
            void TestMethods()
            {
                Testing testing = new Testing();

                testing.TestDieClass();

                testing.TestGameClass();
            }

            // Function to create a game object and execute the main game loop
            void RunGame()
            {
                // Create our game object that will handle the game 
                Game game = new Game();

                game.Initialroll();
                game.MoreRolls();
            }
        }
    }
}
