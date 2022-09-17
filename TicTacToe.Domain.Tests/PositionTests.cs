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
        var positions = new[] {
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

    [Test]
    public void nonSecondDiagonalPositionsReturnFalseOnIsSecondDiagonal()
    {
        var positions = new[] {
            new Position(0, 0),
            new Position(0, 1),
            new Position(1, 0),
            new Position(1, 2),
            new Position(2, 1),
            new Position(2, 2),
            };

        foreach (var position in positions)
            Assert.That(position.IsSecondDiagonal(), Is.False);

    }

    [Test]
    public void IsOnRowReturnsTrueIfPositionMatchesRow()
    {
        var rowNumber = 2;

        Position position = new Position(rowNumber, 1);

        Assert.That(position.IsOnRow(rowNumber), Is.True);
    }


    [Test]
    public void IsOnRowReturnsFalseIfPositionDoesNotMatchRow()
    {
        var rowNumber = 2;

        Position position = new Position(rowNumber, 1);

        Assert.That(position.IsOnRow(1), Is.False);
    }

    [Test]
    public void IsOnColReturnsTrueIfPositionMatchesCol()
    {
        var colNumber = 2;

        Position position = new Position(1, colNumber);

        Assert.That(position.IsOnCol(colNumber), Is.True);
    }


    [Test]
    public void IsOnColReturnsFalseIfPositionDoesNotMatchCol()
    {
        var colNumber = 2;

        Position position = new Position(1, colNumber);

        Assert.That(position.IsOnCol(1), Is.False);
    }
}
