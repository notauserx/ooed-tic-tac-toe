using TicTacToe.Domain;
using TicTacToe.Domain.Services;

namespace TicTacToe.ConsoleApp.Tests;

public class TicTacToeRunnerTests
{

    public TicTacToeRunnerTests()
    {

    }


    [Fact]
    public void testPromtInstructions()
    {
        var reader = new StringReader("1");

        Console.SetIn(reader);

        var writer = new StringWriter();

        Console.SetOut(writer);

        var runner = new TicTacToeGameRunner(
            new Game(),
            new BoardPrintService());

        runner.PrintInstructions();


        var sb = writer.GetStringBuilder();
        var lines = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
        Assert.Equal("___________Welcome to a game of tic tac toe____________", 
            lines[0]);

    }

    [Theory]
    [InlineData(1, 0, 0)]
    [InlineData(2, 0, 1)]
    [InlineData(3, 0, 2)]
    [InlineData(4, 1, 0)]
    [InlineData(5, 1, 1)]
    [InlineData(6, 1, 2)]
    [InlineData(7, 2, 0)]
    [InlineData(8, 2, 1)]
    [InlineData(9, 2, 2)]

    public void canHandleInputFromOneToNine(int input, int expectedX, int expectedY)
    {
        var reader = new StringReader(input.ToString());

        Console.SetIn(reader);

        var writer = new StringWriter();

        Console.SetOut(writer);

        var runner = new TicTacToeGameRunner(
            new Game(),
            new BoardPrintService());

        var position = runner.takeInputPositionToMark();

        Assert.Equal(expectedX, position.X);
        Assert.Equal(expectedY, position.Y);
    }

    [Theory]
    [InlineData(GameOutcome.XWon, "X won")]
    [InlineData(GameOutcome.Tied, "Game tied")]
    [InlineData(GameOutcome.OWon, "O won")]
    public void displaysProperOutComeMessages(GameOutcome outcome, string expectedMessage)
    {
        var result = new TicTacToeGameRunner(
            new Game(),
            new BoardPrintService()).getOutComeMessage(outcome);

        Assert.Equal(expectedMessage, result);
    }
}
