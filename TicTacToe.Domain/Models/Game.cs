namespace TicTacToe.Domain;

public class Game
{
    public Player PlayerX { get; set; }

    public Player PlayerO { get; set; }

    public Player CurrentPlayer { get; set; }

    public Board Board { get; set; }


    public GameOutcome Outcome { get; set; }

    private int numMoves;

    public Game() : 
        this(Player.CreatePlayerX(), Player.CreatePlayerO(), new Board()) { }

    public Game(Player playerX, Player playerO, Board board)
    {
        PlayerX = playerX;
        PlayerO = playerO;
        Board = board;
        CurrentPlayer = playerX;
        Outcome = GameOutcome.Ongoing;
        numMoves = 0;
    }

    public bool IsGameOver() => Outcome != GameOutcome.Ongoing;

    public bool IsPositionOpen(Position position) => Board.GetCell(position).Status == BoardCellStatus.Empty; 

    public void HandleMove(Position position)
    {
        Board.Mark(
            getBoardCellStatusForCurrentPlayer(),
            position);

        numMoves++;
        CheckIfCurrentPlayerWon(position);
    } 

    public void CheckIfCurrentPlayerWon(Position position)
    {
        var isWon = false;

        // the BoardCellStatus of CurrentPlayer
        var cellStatus = Board.GetCell(position).Status;
        var cells = Board.GetCellsAsEnumerable();

        var row = cells.Where(c => c.Position.IsOnRow(position.X));

        // check if the row is won

        isWon = row.All(x => x.Status == cellStatus);

        if (isWon)
        {
            UpdateGameContext(true);
            return;
        }

        var col = cells.Where(c => c.Position.IsOnCol(position.Y));

        // check if col is won
        isWon = isWon || col.All(x => x.Status == cellStatus);


       
        if(position.IsFirstDiagonal())
        {
            // check if first diagonal is won
            isWon = isWon || cells.Where(c => c.Position.IsFirstDiagonal()).All(d => d.Status == cellStatus);
        }
        if(position.IsSecondDiagonal())
        {
            isWon = isWon ||cells.Where(c => c.Position.IsSecondDiagonal()).All(d => d.Status == cellStatus);
        }

        UpdateGameContext(isWon);
    }

    public void UpdateGameContext(bool currentPlayerWon)
    {
        if (currentPlayerWon)
        {
            Outcome = CurrentPlayer.Move == PlayerMove.X
                ? GameOutcome.XWon
                : GameOutcome.OWon;

        }
        else 
        {
            var isComplete = numMoves == 9;
            if (isComplete)
            {
                Outcome = GameOutcome.Tied;
            }
            else
            {
                switchPlayer();
            }

        }
    }

    private void switchPlayer() =>
        CurrentPlayer = CurrentPlayer == PlayerX
            ? PlayerO
            : PlayerX;

    private BoardCellStatus getBoardCellStatusForCurrentPlayer() =>
         CurrentPlayer.Move == PlayerMove.X
            ? BoardCellStatus.X
            : BoardCellStatus.O;
}
