namespace DNCLI;

public class BattleManager
{
    public Character Player { get; set; }
    public List<Character> Enemies { get; set; }
    public GameEnums.BattleState State { get; set; }
    
    public BattleManager()
    {
        
    }
}