using System;
namespace Dice2
{
	public class Die
	{
		public int DiceRoll
		{
			get;
			set;
		}



		public Die()
		{
		}

		public int Roll()
		{
			//Randomises roll to get number from 1 to 6.
			Random roll = new Random();
            DiceRoll = roll.Next(1, 7);
            return DiceRoll;
            
		}
	}
}

