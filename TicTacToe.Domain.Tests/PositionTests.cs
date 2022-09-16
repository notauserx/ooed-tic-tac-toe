namespace TicTacToe.Domain.Tests;


internal class PositionTests
{
    [Test]
    public void firstDiagonalPositionsReturnTrueOnIsFirstDiagonal()
    {
        var positions = new[] {
            new  Position(0, 0),
            new  Position(1, 1),
            new  Position(2, 2),
        };


        foreach (var position in positions)
            Assert.That(position.IsFirstDiagonal(), Is.True);

    }

    [Test]
    public void nonFirstDiagonalPositionsReturnFalseOnIsFirstDiagonal()
    {
        Position[] positions = new[] {
            new Position(0, 1),
            new Position(0, 2),
            new Position(1, 0),
            new Position(1, 2),
            new Position(2, 0),
            new Position(2, 1),
            };

        foreach(var position in positions)
            Assert.That(position.IsFirstDiagonal(), Is.False);

    }

    [Test]
    public void secondDiagonalPositionsReturnTrueOnIsSecondDiagonal()
    {
        var positions = new[] {
            new  Position(0, 2),
            new  Position(1, 1),
            new  Position(2, 0),
        };


        foreach (var position in positions)
            Assert.That(position.IsSecondDiagonal(), Is.True);
    }
}
