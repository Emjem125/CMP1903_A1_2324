using System;
namespace Dice2
{
	public class InvalidDiceException : Exception 
	{
		public InvalidDiceException(): base()
		{
		}

		public InvalidDiceException(string message): base(message)
		{
		
		}

        public InvalidDiceException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}

