namespace DNCLI;

public static class GameRules
{
    public static int CalculateModifier(int statValue)
    {
        return (statValue - 10) / 2;
    }
}