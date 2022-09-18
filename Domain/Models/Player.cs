namespace TicTacToe.Domain;

public class Player
{
    public PlayerMove Move { get; set; }

    public string Name { get; set; }

    private Player(PlayerMove move, string name)
    {
        Move = move;
        Name = name;
    }

    public static Player CreatePlayerX(string playerName = "Player One")
    {
        return new Player(PlayerMove.X, playerName);
    }

    public static Player CreatePlayerO(string playerName = "Player Two")
    {
        return new Player(PlayerMove.O, playerName);
    }
}