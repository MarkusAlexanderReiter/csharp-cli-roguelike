namespace DNCLI;

public static class GameRules
{
    private static Random dice = new Random();
    public static int CalculateModifier(int statValue)
    {
        return (statValue - 10) / 2;
    }

    public static int DiceRoll(int min, int max)
    {
        return dice.Next(min, max);
    }
}