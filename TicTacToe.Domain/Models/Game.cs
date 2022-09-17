namespace TicTacToe.Domain;

public class Game
{
    public Player PlayerX { get; set; }

    public Player PlayerO { get; set; }

    public Board Board { get; set; }


    public Game(Player playerX, Player playerO, Board board)
    {
        PlayerX = playerX;
        PlayerO = playerO;
        Board = board;

    }
}
