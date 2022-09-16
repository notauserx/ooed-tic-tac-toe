// See https://aka.ms/new-console-template for more information
using TicTacToe.Domain;

Console.WriteLine("Hello, World!");

var printService = new BoardPrintService();

var randomBoard = new Board(
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
                        new Cell(new Position(1, 2), BoardCellStatus.Empty),
                    },
                    new Cell[]
                    {
                        new Cell(new Position(2, 0), BoardCellStatus.X),
                        new Cell(new Position(2, 1), BoardCellStatus.X),
                        new Cell(new Position(2, 2), BoardCellStatus.Empty),
                    },
            });

printService.Print(randomBoard);
