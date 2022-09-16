namespace TicTacToe.Domain;

public class Board
{
    public Cell[][] Data { get; private set; }

    public Board()
    {
        Data = new Cell[3][];

        for (int i = 0; i < 3; i++)
        {
            Data[i] = new Cell[3];
            for (int j = 0; j < 3; j++)
            {
                Data[i][j] = new Cell(new Position(i, j));
            }
        }
    }

    public Board(Cell[][] data) { this.Data = data; }

    public void Mark(BoardCellStatus status, Position position)
    {
        if (IsPositionOpen(position))
        {
            Data[position.X][position.Y].Status = status;
        }
    }

    public bool IsPositionOpen(Position position)
    {
        return Data[position.X][position.Y]?.Status == BoardCellStatus.Empty;
    }

}
