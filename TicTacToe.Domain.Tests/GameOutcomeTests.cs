namespace TicTacToe.Domain.Tests
{
    internal class GameHandleMoveTests
    {

        [Test]
        public void testWinOnFirstDiagonal()
        {
            Game game = new Game();
            game.CurrentPlayer = game.PlayerX;
            game.Board = BoardArranger.getBoardWithFirstDiagonalWinForX();

            Assert.That(game.Outcome, Is.EqualTo(GameOutcome.Ongoing));

            game.HandleMove(new Position(2, 2));

            Assert.That(game.Outcome, Is.EqualTo(GameOutcome.XWon));
        }

        [Test]
        public void testWinOnSecondDiagonal()
        {
            Game game = new Game();
            game.CurrentPlayer = game.PlayerX;
            game.Board = BoardArranger.getBoardWithSecondDiagonalWinForX();

            Assert.That(game.Outcome, Is.EqualTo(GameOutcome.Ongoing));

            game.HandleMove(new Position(2, 0));

            Assert.That(game.Outcome, Is.EqualTo(GameOutcome.XWon));
        }

        [Test]
        public void testWinXOnFirstColumn()
        {
            Game game = new Game();
            game.CurrentPlayer = game.PlayerX;
            game.Board = BoardArranger.getBoardWithFirstColWinForX();

            Assert.That(game.Outcome, Is.EqualTo(GameOutcome.Ongoing));

            game.HandleMove(new Position(2, 0));

            Assert.That(game.Outcome, Is.EqualTo(GameOutcome.XWon));
        }

        [Test]
        public void testATiedGameOutcome()
        {
            Game game = new Game();
            game.CurrentPlayer = game.PlayerX;

            Assert.That(game.Outcome, Is.EqualTo(GameOutcome.Ongoing));

            game.HandleMove(new Position(0, 0));
            game.HandleMove(new Position(2, 2));
            game.HandleMove(new Position(1, 1));

            game.HandleMove(new Position(0, 2));
            game.HandleMove(new Position(1, 2));
            game.HandleMove(new Position(1, 0));

            game.HandleMove(new Position(2, 0));
            game.HandleMove(new Position(2, 1));
            game.HandleMove(new Position(0, 1));

            Assert.That(game.Outcome, Is.EqualTo(GameOutcome.Tied));

        }

        [Test]
        public void testFirstColWinForX()
        {
            Game game = new Game();

            Assert.That(game.Outcome, Is.EqualTo(GameOutcome.Ongoing));

            game.HandleMove(new Position(0, 0)); // x
            game.HandleMove(new Position(1, 0)); // o
            game.HandleMove(new Position(0, 1)); // x

            game.HandleMove(new Position(1, 1)); // o

            game.HandleMove(new Position(0, 2)); // x

            Assert.That(game.Outcome, Is.EqualTo(GameOutcome.XWon));
        }

        [Test]
        public void testLastRowWinForX()
        {
            Game game = new Game();
            game.CurrentPlayer = game.PlayerX;

            Assert.That(game.Outcome, Is.EqualTo(GameOutcome.Ongoing));

            game.HandleMove(new Position(2, 0));
            game.HandleMove(new Position(1, 0));
            game.HandleMove(new Position(2, 1));

            game.HandleMove(new Position(1, 1));
            game.HandleMove(new Position(2, 2));

            Assert.That(game.Outcome, Is.EqualTo(GameOutcome.XWon));

        }
    }
}
