using TicTacToe.Domain;
using TicTacToe.Domain.Services;

namespace TicTacToe.ConsoleApp;

internal class TicTacToeGameRunner
{
    private readonly ITicTacToeGameService gameService;
    private readonly IBoardPrintService printService;

    public TicTacToeGameRunner(ITicTacToeGameService gameService,
        IBoardPrintService printService)
    {
        this.gameService = gameService;
        this.printService = printService;
    }
    public void Start()
    {
        printInstructions();

        while(!gameService.IsGameOver())
        {
            promptForInput();
            var position = takeInputPositionToMark();
            // TODO :: check if position is empty;
            gameService.Mark(position);
            printService.Print(gameService.GetBoard());
        }

        // TODO :: print game outcome
    }

    private void printInstructions()
    {
        Console.WriteLine("___________Welcome to a game of tic tac toe____________");
        Console.WriteLine("Please enter a number between 1 to 9 to mark the board.");
    }

    private void promptForInput()
    {
        Console.WriteLine("Player: {0}", gameService.GetCurrentPlayer().Name);
        Console.WriteLine("____________Enter a number between 1 to 9______________");
    }

    private Position takeInputPositionToMark()
    {
        int position;

        while (true)
        {
            var input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out position);
            if(isNumber && position > 0 && position < 10)
            {
                position -= 1;
                break;
            }
            Console.WriteLine("Wrong input: {0}", input);
            Console.WriteLine("____________Enter a number between 1 to 9______________");

        }
        return new Position(position / 3, position % 3);


    }

}
