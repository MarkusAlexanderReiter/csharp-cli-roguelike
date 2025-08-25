namespace DNCLI;

public class Character
{
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }

    public Character()
    {
        Random random = new Random();
        Strength = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
        Dexterity = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
        Constitution = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
        Intelligence = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
        Wisdom = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
        Charisma = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);


    }
}
