namespace TicTacToe.Domain.Tests;

internal class BoardArranger
{
    internal static Board getBoardWithFirstDiagonalWinForX()
    {
        return new Board(
            new Cell[][]
            {
                new Cell[]
                {
                    new Cell(new Position(0, 0), CellStatus.X),
                    new Cell(new Position(0, 1), CellStatus.Empty),
                    new Cell(new Position(0, 2), CellStatus.O),
                },
                new Cell[]
                {
                    new Cell(new Position(1, 0), CellStatus.Empty),
                    new Cell(new Position(1, 1), CellStatus.X),
                    new Cell(new Position(1, 2), CellStatus.O),
                },
                new Cell[]
                {
                    new Cell(new Position(2, 0), CellStatus.Empty),
                    new Cell(new Position(2, 1), CellStatus.Empty),
                    // if x marks this cell, then x wins
                    new Cell(new Position(2, 2), CellStatus.Empty),
                },
            });
    }

    internal static Board getBoardWithSecondDiagonalWinForX()
    {
        return new Board(
            new Cell[][]
            {
                    new Cell[]
                    {
                        new Cell(new Position(0, 0), CellStatus.O),
                        new Cell(new Position(0, 1), CellStatus.Empty),
                        new Cell(new Position(0, 2), CellStatus.X),
                    },
                    new Cell[]
                    {
                        new Cell(new Position(1, 0), CellStatus.O),
                        new Cell(new Position(1, 1), CellStatus.X),
                        new Cell(new Position(1, 2), CellStatus.Empty),
                    },
                    new Cell[]
                    {
                        // if x marks this cell, then x wins
                        new Cell(new Position(2, 0), CellStatus.Empty),
                        new Cell(new Position(2, 1), CellStatus.Empty),
                        new Cell(new Position(2, 2), CellStatus.Empty),
                    },
            });
    }

    internal static Board getBoardWithFirstColWinForX()
    {
        return new Board(
            new Cell[][]
            {
                    new Cell[]
                    {
                        new Cell(new Position(0, 0), CellStatus.X),
                        new Cell(new Position(0, 1), CellStatus.Empty),
                        new Cell(new Position(0, 2), CellStatus.O),
                    },
                    new Cell[]
                    {
                        new Cell(new Position(1, 0), CellStatus.X),
                        new Cell(new Position(1, 1), CellStatus.O),
                        new Cell(new Position(1, 2), CellStatus.Empty),
                    },
                    new Cell[]
                    {
                        // if x marks this cell, then x wins
                        new Cell(new Position(2, 0), CellStatus.Empty),
                        new Cell(new Position(2, 1), CellStatus.Empty),
                        new Cell(new Position(2, 2), CellStatus.Empty),
                    },
            });
    }
}
