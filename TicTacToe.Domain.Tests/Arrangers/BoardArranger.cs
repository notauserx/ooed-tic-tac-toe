namespace TicTacToe.Domain.Tests;

internal class BoardArranger
{
    internal static Board getBoardWithFirstColumnWinForX()
    {
        return new Board(
            new Cell[][]
            {
                new Cell[]
                {
                    new Cell(new Position(0, 0), BoardCellStatus.X),
                    new Cell(new Position(0, 1), BoardCellStatus.Empty),
                    new Cell(new Position(0, 2), BoardCellStatus.O),
                },
                new Cell[]
                {
                    new Cell(new Position(1, 0), BoardCellStatus.X),
                    new Cell(new Position(1, 1), BoardCellStatus.O),
                    new Cell(new Position(1, 2), BoardCellStatus.Empty),
                },
                new Cell[]
                {
                    new Cell(new Position(2, 0), BoardCellStatus.X),
                    new Cell(new Position(2, 1), BoardCellStatus.O),
                    new Cell(new Position(2, 2), BoardCellStatus.X),
                },
            });
    }
    internal static Board getBoardWithFirstDiagonalWinForX()
    {
        return new Board(
            new Cell[][]
            {
                new Cell[]
                {
                    new Cell(new Position(0, 0), BoardCellStatus.X),
                    new Cell(new Position(0, 1), BoardCellStatus.Empty),
                    new Cell(new Position(0, 2), BoardCellStatus.O),
                },
                new Cell[]
                {
                    new Cell(new Position(1, 0), BoardCellStatus.Empty),
                    new Cell(new Position(1, 1), BoardCellStatus.X),
                    new Cell(new Position(1, 2), BoardCellStatus.O),
                },
                new Cell[]
                {
                    new Cell(new Position(2, 0), BoardCellStatus.Empty),
                    new Cell(new Position(2, 1), BoardCellStatus.Empty),
                    new Cell(new Position(2, 2), BoardCellStatus.X),
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
                        new Cell(new Position(0, 0), BoardCellStatus.O),
                        new Cell(new Position(0, 1), BoardCellStatus.Empty),
                        new Cell(new Position(0, 2), BoardCellStatus.X),
                    },
                    new Cell[]
                    {
                        new Cell(new Position(1, 0), BoardCellStatus.O),
                        new Cell(new Position(1, 1), BoardCellStatus.X),
                        new Cell(new Position(1, 2), BoardCellStatus.Empty),
                    },
                    new Cell[]
                    {
                        new Cell(new Position(2, 0), BoardCellStatus.X),
                        new Cell(new Position(2, 1), BoardCellStatus.Empty),
                        new Cell(new Position(2, 2), BoardCellStatus.Empty),
                    },
            });
    }

    internal static Board getBoardWithFirstCollWinForX()
    {
        return new Board(
            new Cell[][]
            {
                    new Cell[]
                    {
                        new Cell(new Position(0, 0), BoardCellStatus.X),
                        new Cell(new Position(0, 1), BoardCellStatus.Empty),
                        new Cell(new Position(0, 2), BoardCellStatus.O),
                    },
                    new Cell[]
                    {
                        new Cell(new Position(1, 0), BoardCellStatus.X),
                        new Cell(new Position(1, 1), BoardCellStatus.O),
                        new Cell(new Position(1, 2), BoardCellStatus.Empty),
                    },
                    new Cell[]
                    {
                        new Cell(new Position(2, 0), BoardCellStatus.X),
                        new Cell(new Position(2, 1), BoardCellStatus.Empty),
                        new Cell(new Position(2, 2), BoardCellStatus.Empty),
                    },
            });
    }

    internal static Board getBoardWitTiedOutcome()
    {
        return new Board(
            new Cell[][]
            {
                    new Cell[]
                    {
                        new Cell(new Position(0, 0), BoardCellStatus.X),
                        new Cell(new Position(0, 1), BoardCellStatus.O),
                        new Cell(new Position(0, 2), BoardCellStatus.O),
                    },
                    new Cell[]
                    {
                        new Cell(new Position(1, 0), BoardCellStatus.O),
                        new Cell(new Position(1, 1), BoardCellStatus.X),
                        new Cell(new Position(1, 2), BoardCellStatus.X),
                    },
                    new Cell[]
                    {
                        new Cell(new Position(2, 0), BoardCellStatus.X),
                        new Cell(new Position(2, 1), BoardCellStatus.X),
                        new Cell(new Position(2, 2), BoardCellStatus.O),
                    },
            });
    }
}
