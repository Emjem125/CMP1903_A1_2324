using System;
namespace CMP1903_A1_2324
{
	internal class Die
	{
		private int _diceRoll;

		//Property
		public int DiceRoll
		{
			get { return _diceRoll; }
			set {  _diceRoll = value; }
		}

		//Method
		public int Rolls()
		{
			//Randomises roll to get number from 1 to 6.
			var roll = new Random(Guid.NewGuid().GetHashCode());
            DiceRoll = roll.Next(1, 7);
            return DiceRoll;
            
		}
	}
}

