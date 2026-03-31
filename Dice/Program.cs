using Dice.classes;

public static class Program
{
    public static void Main(string[] args)
    {
        DiceRoller diceRoller = new DiceRoller();


        for(int i=0; i<20; i++)
        {
            Die dice = new Die(6);
            diceRoller.InsertDie(dice);
        }

        diceRoller.RollAllDice();

        IList<int> results = diceRoller.GetRollingResults();

        foreach(var result in results)
        {
            Console.WriteLine($"{result}\n");
        }
    }
}
