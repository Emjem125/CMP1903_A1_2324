using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice2

{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods
        public int DiceRolls()
        {
            //Calls for the Die Class for each Dice object
            Die dice1 = new Die();
            Die dice2 = new Die();
            Die dice3 = new Die();

            //Calls for the value stored and prints them for each dice object
            Console.WriteLine(dice1.Roll());
            Console.WriteLine(dice2.Roll());
            Console.WriteLine(dice3.Roll());


            //Adds each value from the 3 dice objects then displays it
            int sum = dice1.DiceRoll + dice2.DiceRoll + dice3.DiceRoll;
            Console.WriteLine("The total of all the rolls are:" + sum);
            return sum;

        }
    }
}
