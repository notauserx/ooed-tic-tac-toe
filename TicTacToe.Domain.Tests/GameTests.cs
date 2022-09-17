namespace TicTacToe.Domain.Tests;

internal class GameTests
{
    [Test]
    public void gameContructorInitializesAnEmptyBoard()
    {
        var game = new Game(Player.CreatePlayerX(),
            Player.CreatePlayerO(),
            new Board());

        for(var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                Assert.That(game.Board.Data[i][j].Status, Is.EqualTo(BoardCellStatus.Empty));

            }
        }

    }

    [Test]
    public void gameDefaultContructorInitializesAnEmptyBoard()
    {
        var game = new Game();

        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                Assert.That(game.Board.Data[i][j].Status, Is.EqualTo(BoardCellStatus.Empty));

            }
        }

    }

}
