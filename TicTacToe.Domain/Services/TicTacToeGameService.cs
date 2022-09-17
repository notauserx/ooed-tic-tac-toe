namespace TicTacToe.Domain.Services;

internal class TicTacToeGameService
{
    private readonly Game game;
    private readonly GameStateManager stateManager;
    private Player currentPlayer;
    private TicTacToeGameService(Player x, Player o)
    {
        game = new Game(x, o, new Board());
        currentPlayer = game.PlayerX;
    }

    public void Mark(Position position)
    {
        markPosition(position);
        switchPlayer();
        stateManager.UpdateState(game.Board);
    }

    private void markPosition(Position position)
    {
        if (stateManager.GameState == GameState.Finished) return;

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
