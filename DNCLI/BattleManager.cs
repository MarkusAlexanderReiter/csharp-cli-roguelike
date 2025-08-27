namespace DNCLI;

public class BattleManager
{
    public Character Player { get; set; }
    public List<Character> Enemies { get; set; }
    public GameEnums.BattleState State { get; set; }
    
    public BattleManager(Character player, List<Character> enemies)
    {
        Player = player;
        Enemies = enemies;
        State = GameEnums.BattleState.PlayerTurn;
        
    }

    public void StartBattle()
    {
        while (State != GameEnums.BattleState.BattleOver)
        {
            switch (State)
            {
                case GameEnums.BattleState.PlayerTurn:
                    HandlePlayerTurn();

                    break;
                case GameEnums.BattleState.EnemyTurn:
                    HandleEnemiesTurn();
                    break;

            }
        }
    }

    private void HandlePlayerTurn()
    {
        Console.WriteLine("What will you do?\n1. Attack\n2. Flee");
        var input = Console.ReadLine();
        if (int.TryParse(input, out int choice))
        {
            if (choice == 1)
            {

                if (Enemies.Count > 1)
                {
                    var enemy = SelectEnemyTarget(Enemies);
                    CombatCalculations.Attack(Player, enemy);
                }

                else
                {
                    CombatCalculations.Attack(Player, Enemies[0]);
                }
                                
                State = GameEnums.BattleState.EnemyTurn;
            }
            else if (choice == 2)
            {
                FleeCalculation(Player, Enemies);
            }
        }
        else
        {
            Console.WriteLine("Please enter a number between 1 and 2.");
        }
    }
    public void FleeCalculation(Character player, List<Character> enemies)
    {
        int playerFleeChance = GameRules.DiceRoll(1, 21) + GameRules.CalculateModifier(Player.Dexterity);
        bool escaped = true; //Assume success until someone beats the player
        foreach (var enemy in enemies)
        {
            int enemyRoll = GameRules.DiceRoll(1, 21) + GameRules.CalculateModifier(enemy.Dexterity);
            if (enemyRoll > playerFleeChance)
            {
                escaped = false;
                Console.WriteLine($"{enemy} cuts you off!");
            }
        }
        if (escaped)
        {
            Console.WriteLine("You fled the battle!");
            State = GameEnums.BattleState.BattleOver;
        }
    }
    private void HandleEnemiesTurn()
    {
        foreach (var enemy in Enemies)
        {
            CombatCalculations.Attack(enemy, Player);
        }
        State  = GameEnums.BattleState.PlayerTurn;
    }
    private Character SelectEnemyTarget(List<Character> enemies)
    {
        while (true)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {enemies[i].Name}");
            }
    
            var enemyChoice = Console.ReadLine();
            if (int.TryParse(enemyChoice, out int chosenEnemy) && chosenEnemy <= enemies.Count && chosenEnemy > 0)
            {
                return enemies[chosenEnemy-1];
            }
            else
            {
                Console.WriteLine("Please choose a valid enemy to attack");
            }
        }
    }

    private void IsBattleOver()
    {
        //is player dead or all enemies dead?
    }
}