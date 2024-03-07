using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Die
{
    public int RollValue { get; set; } //property
    public void Roll() // Dice.Roll() method -- use Dice.Roll()

    {
        List<int> RollValue = new List<int>() { 1, 2, 3, 4, 5, 6 }; // list sets the numbers on die
        Random rnd = new Random();
        int randIndex = rnd.Next(RollValue.Count);
        int random = RollValue[randIndex];

        Console.WriteLine(random); // prints the random value from the list
    }
}

    internal class Game
    {
        Die dice1 = new Die(RollValue); // creates a dice object (of class Die)
        Die dice2 = new Die(RollValue);
        Die dice3 = new Die(RollValue);

    /*
        * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
        *
        * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
        * rolls could be continous, and the totals and other statistics could be summarised for example.
        */

    //Methods

}

