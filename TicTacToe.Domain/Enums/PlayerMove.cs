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
    // TODO :: rename to undecided maybe ...
    Ongoing,
    Tied,
    XWon,
    OWon
}


// TODO :: remove this enum, can be calculated from GameOutcome
public enum GameState
{
    Running,
    Finished
}

