namespace TicTacToe.Domain;

public class Game
{
    public Player PlayerX { get; set; }

    public Player PlayerO { get; set; }

    public Board Board { get; set; }

    public GameStateManager GameStateManager { get; set; }



    public Game(Player playerX, Player playerO, Board board, GameStateManager gameStateManager)
    {
        PlayerX = playerX;
        PlayerO = playerO;
        Board = board;

        GameStateManager = gameStateManager;

    }

    public void MarkForPlayetX(Position position)
    {
        mark(BoardCellStatus.X, position);
    }

    public void MarkForPlayerO(Position position)
    {
        mark(BoardCellStatus.O, position);
    }

    private void mark(BoardCellStatus mark, Position position)
    {
        if (GameStateManager.GameState == GameState.Finished) return;

        Board.Mark(mark, position);

        GameStateManager.UpdateState(Board);
    }
}
