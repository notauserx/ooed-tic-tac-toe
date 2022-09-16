namespace TicTacToe.Domain;

public class Cell
{
    public BoardCellStatus Status { get; set; }

    public Position Position { get; set; }

    public Cell(Position position, BoardCellStatus status = BoardCellStatus.Empty)
    {
        Position = position;
        Status = status;
    }


}
