using System.Runtime.InteropServices.ComTypes;

namespace DNCLI;

public class Character
{
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
    public int MaxHealth { get; set; }
    public int ArmorClass { get; set; }

    public Character()
    {
        AssignStats();
        MaxHealth = 10 + GameRules.CalculateModifier(Constitution);
        ArmorClass = 10 + GameRules.CalculateModifier(Dexterity);
    }
    
    protected virtual int RollStat() //protected = private but child classes can access, virtual = can be overridden
    {
        Random random = new Random();
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }
    protected virtual void AssignStats()
    {
        Strength = RollStat();
        Dexterity = RollStat();
        Constitution = RollStat();
        Intelligence = RollStat();
        Wisdom = RollStat();
        Charisma = RollStat();
    }

    public void Attack(Character defender)
    {
        Random random = new Random();
        int attackRoll = random.Next(1, 21);
        int defenderArmourClass = defender.ArmorClass;

        if (attackRoll > defenderArmourClass)
        {
            
        }
    }
}
