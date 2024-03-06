using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324

{
    internal class Game
    {


        //Methods
        public int Roll()
        {
            //Calls for the Die Class for each Dice object
            Die dice1 = new Die();
            Die dice2 = new Die();
            Die dice3 = new Die();

            //Calls for the value stored and prints them for each dice object
            Console.WriteLine($"Dice 1 rolled a " + dice1.Rolls());
            Console.WriteLine($"Dice 2 rolled a " + dice2.Rolls());
            Console.WriteLine($"Dice 3 rolled a " + dice3.Rolls());

            //Adds each value from the 3 dice objects then displays it
            int Sum = dice1.DiceRoll + dice2.DiceRoll + dice3.DiceRoll;
            Console.WriteLine("The total of all the rolls are:" + Sum);
            return Sum;
        }

         public int Sum 
        {

            get;
            set;

        }
    }
}
