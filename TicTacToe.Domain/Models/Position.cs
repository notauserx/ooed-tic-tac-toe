namespace TicTacToe.Domain;

public class Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public Position(int x, int y)
    {
        // TODO :: include validation logic
        // x and y should be between 0 and 2
        X = x;
        Y = y;
    }

    public bool IsFirstDiagonal()
    {
        return X == Y;
    }

    public bool IsSecondDiagonal()
    {
        return 
            (X == 1 && Y == 1) ||
            (X == 0 && Y == 2) ||
            (X == 2 && Y == 0);
    }

    public bool IsOnRow(int row)
    {
        return X == row;
    }

    public bool IsOnCol(int col)
    {
        return Y == col;
    }


}
