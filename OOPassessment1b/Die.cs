using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPassessment1b
{
    public class Die
    {
        public void RollValue() { get; set; } // Dice.Roll() method -- use Dice.Roll()
        {
            List<int> RollValue = new List<int>() { 1, 2, 3, 4, 5, 6 }; // list sets the numbers on die
            Random rnd = new Random();
            int randIndex = rnd.Next(RollValue.Count);
            int random = RollValue[randIndex];

            Console.WriteLine(random); // prints the random value from the list
        }
    }
}


