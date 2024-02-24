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
			Random roll = new Random();
            DiceRoll = roll.Next(1, 7);
            return DiceRoll;
            
		}
	}
}

