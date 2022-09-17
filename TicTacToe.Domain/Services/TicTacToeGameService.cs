namespace TicTacToe.Domain.Services;

public class TicTacToeGameService : ITicTacToeGameService
{
    private readonly Game game;
    private readonly GameStateManager stateManager;
    private Player currentPlayer;
    private TicTacToeGameService(Player x, Player o)
    {
        game = new Game(x, o, new Board());
        currentPlayer = game.PlayerX;
        stateManager = new GameStateManager();
    }

    public Board GetBoard() => game.Board;

    public Player GetCurrentPlayer() => currentPlayer;

    public void Mark(Position position)
    {
        if (stateManager.GameState == GameState.Finished) return;

        markPosition(position);
        switchPlayer();
        stateManager.UpdateState(game.Board);
    }

    public bool IsGameOver() => stateManager.GameState == GameState.Finished;


    private void markPosition(Position position)
    {
        if (currentPlayer == game.PlayerX)
            game.Board.Mark(BoardCellStatus.X, position);
        else
            game.Board.Mark(BoardCellStatus.O, position);
    }

    private void switchPlayer() =>
        currentPlayer = currentPlayer == game.PlayerX
            ? game.PlayerO
            : game.PlayerX;

    public static TicTacToeGameService CreateSimpleGameService()
    {
        return new TicTacToeGameService(Player.CreatePlayerX(), Player.CreatePlayerO());
    }

}
