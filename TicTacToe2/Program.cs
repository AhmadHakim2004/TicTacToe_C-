using System;
using System.Numerics;
using TicTacToe2;

namespace TicTacToe2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic Tac Toe!");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        int numPlayers = CountOfPlayers();
        Console.WriteLine("       |");
        Console.WriteLine("       V");

        // Enter the name and pick a marker for players
        List<Player> players = SetupPlayers(numPlayers);
        Console.WriteLine("       |");
        Console.WriteLine("       V");

        var board = Initialize();
        Console.WriteLine("\nLet's start the game, shall we?");
        Console.ReadLine();

        char print = Print(board);

        //char gameStart = StartGame();

         

        int movesPlayed = 0;
        //bool gameEnd = false;
        Print(board);

        // The game plays, until winner/loser/draw
        while (true)
        {
            for (int p = 0; p < players.Count; p++)
            {
                var currentPlayer = players[p];
                Console.WriteLine($"Current player is : {currentPlayer.Name}");
                Console.Write("\nPlease enter row: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter column: ");
                int col = Convert.ToInt32(Console.ReadLine());

                board[row, col] = currentPlayer.Marker;
                Print(board);
                if (currentPlayer.Marker == board[0, 0] && currentPlayer.Marker == board[0, 1] && currentPlayer.Marker == board[0, 2])
                {
                    Console.WriteLine(currentPlayer.Marker + " has won the game!");
                    Console.ReadKey();
                    break;
                }
                else if (currentPlayer.Marker == board[1, 0] && currentPlayer.Marker == board[1, 1] && currentPlayer.Marker == board[1, 2])
                {
                    Console.WriteLine(currentPlayer.Marker + " has won the game!");
                    Console.ReadKey();
                    break;
                }
                else if (currentPlayer.Marker == board[2, 0] && currentPlayer.Marker == board[2, 1] && currentPlayer.Marker == board[2, 2])
                {
                    Console.WriteLine(currentPlayer.Marker + " has won the game!");
                    Console.ReadKey();
                    break;
                }
                movesPlayed = movesPlayed + 1;
                if (movesPlayed == 9)
                {
                    Console.WriteLine("DRAW");
                    break;
                }
            }


            // Check player win.


        }


        Console.ReadLine();
    }



    static int CountOfPlayers()
    {
        int countPlayers = 0;
        while (countPlayers == 0)
        {
            Console.Write("How many players?: ");
            if (!int.TryParse(Console.ReadLine(), out countPlayers))
            {
                Console.WriteLine("Enter an integer value (Example: 2)");
            }
        }
        Console.WriteLine($"Starting game with {countPlayers} players.");
        return countPlayers;
    }

    static List<Player> SetupPlayers(int numPlayers)
    {
        List<Player> players = new List<Player>();
        //players.Add(new Player { Name = "", Marker = ""});

        for (int i = 0; i < numPlayers; i++)
        {
            var p = new Player();
            Console.Write("Enter the players name: ");
            p.Name = Console.ReadLine();
            Console.Write($"Pick a letter for {p.Name}: ");
            p.Marker = Console.ReadKey().KeyChar;

            Console.WriteLine();
            Console.WriteLine($"{p.Name} chose '{p.Marker}' as their Tic Tac Toe marker");
            Console.ReadLine();

            players.Add(p);
        }
        return players;
    }




    //static char ChangeTurn(char currentPlayer)
    //{
    //    if (currentPlayer == 'X')
    //    {
    //        Console.WriteLine("... is up next");
    //        return 'O';
    //    }
    //    else
    //    {
    //        Console.WriteLine("... is up next!");
    //        return 'X';
    //    }
    //}


    static int getBoardSize()
    {
        int size = 0;

        while (size > 5 || size < 2)
        {
            Console.Write("Choose a board size (Between 2 to 5): ");
            if (!int.TryParse(Console.ReadLine(), out size) || size > 5 || size < 2) 
            {
                Console.WriteLine("Enter an integer value (Between 2 to 5!)");
            }
        }
        Console.WriteLine($"Starting game with {size} x {size}.");

        return size;
    }

    static char[,] Initialize()
    {
        var size = getBoardSize();
        char[,] board = new char[size, size]; // Two dimensional array of character

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                board[row, col] = ' ';
            }
        }
        return board;
    }

    static char Print(char[,] board)
    {
        Console.Clear();

        //Console.WriteLine("  | 0 | 1 | 2 |");
        int boardSize = (int)Math.Sqrt(board.Length);
        Console.Write("\n ");
        for (int col = 1; col <= boardSize; col++)
        {
            Console.Write($" | {col}");
        }
        Console.WriteLine(" |");

        for (int row = 1; row <= boardSize; row++)
        {

            Console.Write(row + " | ");
            for (int col = 1; col <= boardSize; col++)
            {
                Console.Write(board[row-1, col-1]);
                Console.Write(" | ");
            }
            Console.WriteLine();
        }
        return (char)boardSize;
    }
}

