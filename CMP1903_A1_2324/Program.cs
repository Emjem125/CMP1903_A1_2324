namespace Dice2;

class Program
{
    static void Main(string[] args)

    {
        try
        {
            //RunTests();
            Game Sid = new Game();
            Sid.DiceRolls();
        }
        catch(InvalidDiceException e)
        {
            Console.WriteLine($"You did something stupid {e}");
        }
        catch(Exception e)
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

