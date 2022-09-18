namespace TicTacToe.Domain.Services;
public class BoardPrintService : IBoardPrintService
{
    public void Print(Board board)
    {
        Console.WriteLine("");

        var firstRow = true;
        foreach(var rows in board.Data)
        {
            if (!firstRow) Console.WriteLine("------");
            var first = true;

            foreach(var cell in rows)
            {
                if (!first) Console.Write("|");
                Console.Write(GetCellContent(cell.Status));
                first = false;
            }
            firstRow = false;
            Console.WriteLine();
        }

        Console.WriteLine("");

    }

    public string GetCellContent(CellStatus status) => status switch
    {
        CellStatus.X => "X",
        CellStatus.O => "O",
        CellStatus.Empty => " ",

    };
}