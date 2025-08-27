namespace DNCLI;

public static class CombatCalculations
{
    public static void Attack(Character attacker, Character defender)
    {
        int attackRoll = GameRules.DiceRoll(1, 21);
        int defenderArmourClass = defender.ArmorClass;

        if (attackRoll > defenderArmourClass) //Attack hits
        {
            int damage = GameRules.DiceRoll(1, 9) + GameRules.CalculateModifier(attacker.Strength); //TODO Replace with weapon stats etc.
            defender.ApplyDamage(damage);
            Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damage} damage.");
        }
        else
        {
            int randomtext = GameRules.DiceRoll(1, 3);
            switch (randomtext)
            {
                case 1:
                    Console.WriteLine($"{attacker.Name} missed his attack.");
                    break;
                case 2:
                    Console.WriteLine($"{defender.Name} avoided the attack");
                    break;
            }
        }
    }

}