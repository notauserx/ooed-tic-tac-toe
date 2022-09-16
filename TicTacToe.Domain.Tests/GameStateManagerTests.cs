namespace TicTacToe.Domain.Tests
{
    internal class GameStateManagerTests
    {

        [Test]
        public void testWinOnFirstDiagonal()
        {
            GameStateManager stateManager = new GameStateManager();
            stateManager.UpdateState(BoardArranger.getBoardWithFirstDiagonalWinForX());

            Assert.That(stateManager.GameOutcome, Is.EqualTo(GameOutcome.XWon));
        }

        [Test]
        public void testWinOnSecondDiagonal()
        {
            GameStateManager stateManager = new GameStateManager();
            stateManager.UpdateState(BoardArranger.getBoardWithSecondDiagonalWinForX());

            Assert.That(stateManager.GameOutcome, Is.EqualTo(GameOutcome.XWon));
        }

        [Test]
        public void testWinXOnFirstColumn()
        {
            GameStateManager stateManager = new GameStateManager();
            stateManager.UpdateState(BoardArranger.getBoardWithFirstCollWinForX());

            Assert.That(stateManager.GameOutcome, Is.EqualTo(GameOutcome.XWon));
        }

        [Test]
        public void testATiedGameOutcome()
        {
            GameStateManager stateManager = new GameStateManager();
            stateManager.UpdateState(BoardArranger.getBoardWitTiedOutcome());

            Assert.That(stateManager.GameOutcome, Is.EqualTo(GameOutcome.Tied));
        }
    }
}
