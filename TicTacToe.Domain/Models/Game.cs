namespace TicTacToe.Domain;

public class Game
{
    public Player PlayerX { get; set; }

    public Player PlayerO { get; set; }

    public Board Board { get; set; }

    public GameStateManager StateManager { get; private set; }

    public Player CurrentPlayer { get; private set; }

    public Game(Player playerX, Player playerO, Board board, GameStateManager gameStateManager)
    {
        PlayerX = playerX;
        PlayerO = playerO;
        Board = board;

        StateManager = gameStateManager;

        CurrentPlayer = playerX;
    }

    public void MarkPosition(Position position)
    {
        if (StateManager.GameState == GameState.Finished) return;

        if (CurrentPlayer == PlayerX)
            mark(BoardCellStatus.X, position);
        else
            mark(BoardCellStatus.O, position);


    }

    public void UpdateStatus() => StateManager.UpdateState(Board);


    public void SwitchPlayer() =>
    
        CurrentPlayer = CurrentPlayer == PlayerX
            ? PlayerO
            : PlayerX;

    private void mark(BoardCellStatus mark, Position position) =>
        Board.Mark(mark, position);
}
