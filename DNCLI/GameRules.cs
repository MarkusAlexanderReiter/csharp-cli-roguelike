namespace DNCLI;

public static class GameRules
{
    private static Random _dice = new Random();
    public static int CalculateModifier(int statValue)
    {
        return (statValue - 10) / 2;
    }

    public static int DiceRoll(int min, int max)
    {
        return _dice.Next(min, max);
    }
}