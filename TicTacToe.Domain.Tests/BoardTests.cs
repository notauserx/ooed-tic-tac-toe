namespace TicTacToe.Domain.Tests;

internal class BoardTests
{
    [Test]
    public void boardContructorInitializesAnEmptyBoard()
    {
        var cells = new Board().Data.SelectMany(x => x);

        foreach (var cell in cells)
        {
            Assert.That(cell.Status, Is.EqualTo(BoardCellStatus.Empty));
        }
    }
}
