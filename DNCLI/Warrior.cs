namespace DNCLI;

public class Warrior : Character // : means it inherits from
{
    protected override void AssignStats()
    {
        Strength = Roll4d6DropLowest();
        Dexterity = base.RollStat();
        Constitution = base.RollStat();
        Intelligence = base.RollStat();
        Wisdom = base.RollStat();
        Charisma = base.RollStat();
    }

    private int Roll4d6DropLowest()
    {
        Random random = new Random();
        var rolls = new List<int>();
        for (int i = 0; i < 4; i++)
        {
            rolls.Add(random.Next(1, 7));
        }
        rolls.Sort();
        return rolls[1];
    }
    
}