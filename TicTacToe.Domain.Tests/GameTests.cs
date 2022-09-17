namespace TicTacToe.Domain.Tests;

internal class GameTests
{
    [Test]
    public void gameContructorInitializesPlayerXAsCurrentPlayer()
    {
        var game = new Game(Player.CreatePlayerX(), 
            Player.CreatePlayerO(), 
            new Board(), 
            new GameStateManager());

        Assert.That(game.CurrentPlayer, Is.EqualTo(game.PlayerX));
    }
}
