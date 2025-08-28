using System.Runtime.InteropServices.ComTypes;

namespace DNCLI;

public class Character
{
    #region Character Stats
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
    public int MaxHealth { get; set; }
    public int ArmorClass { get; set; }
    public int CurrentHealth { get; set; }
    public string Name { get; set; }
    public bool IsDead => CurrentHealth <= 0;
    public bool IsAlive => !IsDead;
    
    #endregion

    #region Character Creation Logic


    public Character()
    {
        AssignStats();
        MaxHealth = 10 + GameRules.CalculateModifier(Constitution);
        ArmorClass = 10 + GameRules.CalculateModifier(Dexterity);
        CurrentHealth = MaxHealth;
        Name = GetName();
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

    protected virtual string GetName()
    {
        Console.WriteLine("Enter your name: ");
        string userInput = Console.ReadLine();
        if (userInput == "")
        {
            return "Player";
        }
        else
        {
            return userInput;
        }
    }
    #endregion
    
    public void ApplyDamage(int damage)
    {
        CurrentHealth = Math.Max(CurrentHealth - damage, 0); //Math.Max returns the bigger of the two values
    }
    
}
