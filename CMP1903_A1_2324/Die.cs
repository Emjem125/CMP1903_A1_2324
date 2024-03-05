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

		public int Rolls()
		{
			//Randomises roll to get number from 1 to 6.
			var roll = new Random(Guid.NewGuid().GetHashCode());
            DiceRoll = roll.Next(1, 7);
            return DiceRoll;
            
		}
	}
}

