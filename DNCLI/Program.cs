namespace DNCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player = new Character();
            Console.WriteLine($"Player Strength: {player.Strength}");
            Console.WriteLine($"Player Dexterity: {player.Dexterity}");
            Console.WriteLine($"Player Constitution: {player.Constitution}");
            Console.WriteLine($"Player Wisdom: {player.Wisdom}");
            Console.WriteLine($"Player Intelligence: {player.Intelligence}");
            Console.WriteLine($"Player Charisma: {player.Charisma}");

        }
    }
}