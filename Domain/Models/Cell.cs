namespace TicTacToe.Domain;

public class Cell
{
    public CellStatus Status { get; set; }

    public Position Position { get; set; }

    public Cell(Position position, CellStatus status = CellStatus.Empty)
    {
        Position = position;
        Status = status;
    }


}
