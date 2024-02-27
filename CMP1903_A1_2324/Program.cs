using System;
namespace Dice2
{ 

class Program
{
    static void Main(string[] args)

    {
        try
        {
            //RunTests();
            Game Dice = new Game();
            Dice.Roll();
        }
        /*catch(InvalidDiceException e)
        {
            Console.WriteLine($"There is an issue {e}");
        }*/
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadKey();
    }

    private static void RunTests()
    {
        Testing dieTests = new Testing();
        dieTests.Run();
    }
}
}