using TicTacToe.Domain;
using TicTacToe.Domain.Services;

namespace TicTacToe.ConsoleApp;

internal class TicTacToeGameRunner
{
    private readonly Game game;
    private readonly IBoardPrintService printService;

    public TicTacToeGameRunner(Game game,
        IBoardPrintService printService)
    {
        this.game = game;
        this.printService = printService;
    }
    public void Start()
    {
        printInstructions();

        while(!game.IsGameOver())
        {
            promptForInput();
            Position position;
            while (true)
            {
                position = takeInputPositionToMark();
                if (game.IsPositionOpen(position))
                    break;
                else
                {
                    Console.WriteLine("Position is already taken, try an empty position.");
                }
            }
            game.HandleMove(position);
            printService.Print(game.Board);
        }

        // TODO :: print game outcome
    }

    private void printInstructions()
    {
        Console.WriteLine("___________Welcome to a game of tic tac toe____________");
        printService.Print(game.Board);
        Console.WriteLine("Please enter a number between 1 to 9 to mark the board.");
    }

    private void promptForInput()
    {
        Console.WriteLine("Player: {0}", game.CurrentPlayer.Name);
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
