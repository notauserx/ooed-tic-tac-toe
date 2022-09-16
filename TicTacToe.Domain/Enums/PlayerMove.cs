namespace TicTacToe.Domain;

public enum PlayerMove{
    X,
    O
}

public enum BoardCellStatus
{
    Empty,
    X,
    O
}

public enum GameOutcome
{
    Ongoing,
    Tied,
    XWon,
    OWon
}

public enum GameState
{
    Running,
    Finished
}

