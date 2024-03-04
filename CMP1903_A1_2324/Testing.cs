using System;
using System.Diagnostics;

namespace Dice2
{
	public class Testing
	{
		public Testing()
		{
		}

		//Tests that the Die runs
        internal void Run()
        {
			CreateDie();
			TestRollDie();
        }

		//Checks whether the Die is null or not
		public void CreateDie()
		{
			Die testdie = new Die();
			if(testdie == null)
			{
				throw new ArgumentNullException();
			}
		}
		//Unit Test - Testing the Die Roll does not have the value 0.
		public void TestRollDie()
		{
			//Arrange
			Die testdie = new Die();
			//Act
			var result = testdie.Rolls();
			//Assert
            Debug.Assert(result != 0);

			/*if(result != 0)
			{
				throw new InvalidDiceException("Value is 0");
			}*/

		}
		//Unit Test - Testing the Die Roll is below 7.
		public void TestDice_WhenCallingRollMethod_ResultLessThanSeven()
		{
			//Arrange
			Die testdie = new Die();
			//Act 
			var testresult = testdie.Rolls();
			//Assert
			Debug.Assert(testresult<= 7);
		}
    }
}

