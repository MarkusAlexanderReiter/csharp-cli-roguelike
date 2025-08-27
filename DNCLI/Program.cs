namespace DNCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player = new Warrior();
            Character monster = new Character();
            Console.WriteLine($"========={player.Name} Stats=========");
            Console.WriteLine($"Player Strength: {player.Strength}");
            Console.WriteLine($"Player Dexterity: {player.Dexterity}");
            Console.WriteLine($"Player Constitution: {player.Constitution}");
            Console.WriteLine($"Player Wisdom: {player.Wisdom}");
            Console.WriteLine($"Player Intelligence: {player.Intelligence}");
            Console.WriteLine($"Player Charisma: {player.Charisma}");
            Console.WriteLine($"Player MaxHealth: {player.MaxHealth}");
            Console.WriteLine($"Player ArmorClass: {player.ArmorClass}");
            Console.WriteLine(" ");
            Console.WriteLine($"========={monster.Name} Stats=========");
            Console.WriteLine($"Monster Strength: {monster.Strength}");
            Console.WriteLine($"Monster Dexterity: {monster.Dexterity}");
            Console.WriteLine($"Monster Constitution: {monster.Constitution}");
            Console.WriteLine($"Monster Wisdom: {monster.Wisdom}");
            Console.WriteLine($"Monster Intelligence: {monster.Intelligence}");
            Console.WriteLine($"Monster Charisma: {monster.Charisma}");
            Console.WriteLine($"Monster MaxHealth: {monster.MaxHealth}");
            Console.WriteLine($"Monster ArmorClass: {monster.ArmorClass}");
            Console.WriteLine("What will you do? " + "1. Attack" + "2. Flee");
        }
    }
}