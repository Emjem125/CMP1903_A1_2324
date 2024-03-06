using System;
namespace CMP1903_A1_2324
{ 

internal class Program
{
    static void Main(string[] args)

    {
        
        try
        {
            RunTests();
            Game Dice = new Game();
            Dice.Roll();
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        void RunTests()
            {
                Testing dieTests = new Testing();
                dieTests.Run();
        }
            Console.ReadKey();
    }

    
}
}