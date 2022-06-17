using System.Security.AccessControl;

namespace BattleShipConsole;

public class Player
{
    private string name;

    private Board board;

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }
}