﻿namespace TicTacToe.Domain;

public class GameStateManager
{
    public GameState GameState { get; set; }

    public GameOutcome GameOutcome { get; set; }


    public void UpdateState(Board board)
    {
        var cells = board.Data
           .SelectMany(x => x);

        var xWon = isWon(cells, BoardCellStatus.X);
        var oWon = isWon(cells, BoardCellStatus.O);

        if (xWon)
        {
            GameOutcome = GameOutcome.XWon;
        }

        if (oWon)
        {
            GameOutcome = GameOutcome.OWon;
        }

        var isCompleted = isComplete(cells);
        if(!xWon && !oWon && isCompleted)
        {
            GameOutcome = GameOutcome.Tied;
        }

        if (xWon || oWon || isCompleted)
        {
            GameState = GameState.Finished;
        }
    }

    private bool isWon(IEnumerable<Cell> cells, BoardCellStatus status)
    {

        var hasAnyRow = Enumerable.Range(0, 2)
            .Any(x => checkWithPredicate(cells, c => c.Position.X == x, status));

        var hasAnyCol = Enumerable.Range(0, 2)
            .Any(y => checkWithPredicate(cells, c => c.Position.Y == y, status));

        var hasADiagonal = checkDiagonal(cells, status);

        return hasAnyRow || hasAnyCol || hasADiagonal;
    }

    private bool isComplete(IEnumerable<Cell> cells)
    {
        return cells.All(x => x.Status != BoardCellStatus.Empty);
    }

    private bool checkWithPredicate(IEnumerable<Cell> cells, Func<Cell, bool> predicate,
        BoardCellStatus status)
    {
        return cells.Where(predicate).All(x => x.Status == status);
    }

    private bool checkDiagonal(IEnumerable<Cell> cells, BoardCellStatus status)
    {

        var firstDiagonalCells = cells.Where(x => x.Position.IsFirstDiagonal());
        var secondDiagonalCells = cells.Where(x => x.Position.IsSecondDiagonal());

        return
            firstDiagonalCells.All(c => c.Status == status) ||
            secondDiagonalCells.All(c => c.Status == status);
    }
}
