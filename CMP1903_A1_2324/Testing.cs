using System;
using System.Diagnostics;

namespace Dice2
{
	public class Testing
	{
		public Testing()
		{
		}

        internal void Run()
        {
			CreateDie();
			TestRollDie();
        }

		public void CreateDie()
		{
			Die testdie = new Die();
			if(testdie == null)
			{
				throw new ArgumentNullException();
			}
		}
		public void TestRollDie()
		{
			Die testdie = new Die();
			var result = testdie.Roll();
            Debug.Assert(result != 0);

			/*if(result != 0)
			{
				throw new InvalidDiceException("Value is 0");
			}*/

		}
    }
}

