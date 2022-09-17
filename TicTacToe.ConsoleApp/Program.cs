// See https://aka.ms/new-console-template for more information
using TicTacToe.Domain;
using TicTacToe.Domain.Services;
using TicTacToe.ConsoleApp;



var gameRunner = new TicTacToeGameRunner(
    new Game(),
    new BoardPrintService());

gameRunner.Start();
