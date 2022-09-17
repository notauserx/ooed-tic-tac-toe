namespace TicTacToe.Domain.Services;

public interface ITicTacToeGameService
{
    Board GetBoard();
    Player GetCurrentPlayer();
    void Mark(Position position);
    bool IsGameOver();
}