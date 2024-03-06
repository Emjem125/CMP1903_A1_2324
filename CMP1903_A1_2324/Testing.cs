using System;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
	public class Testing
	{

		//Tests that the Die and Game runs
		internal void Run()
		{
			CreateDie();
			TestRollDie();
			TestDiceRange();
			CreateGame();

		}


		//Checks whether the Die is null or not
		public void CreateDie()
		{
			Die testdie = new Die();
			if (testdie == null)
			{
				throw new ArgumentNullException();
			}
		}
		//Unit Test - Testing the Die Roll does not have the value 0.
		public void TestRollDie()
		{
			//Arrange
			Die testDie = new Die();
			//Act
			var result = testDie.Rolls();
			//Assert
			Debug.Assert(result != 0);
		}
		//Unit Test - Testing the Die Roll is below 7.
		public void TestDiceRange()
		{
			//Arrange
			Die testDie = new Die();
			//Act 
			var testResult = testDie.Rolls();
			//Assert
			Debug.Assert(testResult > 0 && testResult < 7);
			Debug.Assert(testResult >= 1 && testResult <= 6);



		}
		//Checks whether the Game is null or not
		public void CreateGame()
		{
			Game testGame = new Game();
			if (testGame == null)
			{
				throw new ArgumentNullException();
			}
		}

		public void TestSum()
		{
			Game testSum = new Game();
			Debug.Assert(testSum.Sum > 3 && testSum.Sum < 18);


		}
	}
}