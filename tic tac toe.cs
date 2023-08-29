
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac__toe
{
    internal class Program
    {

        public static string player1;
        public static string player2;
        public static int player;


        static void Main(string[] args)
        {
            int gameStatus = 0;
            int currentPlayer = -1;
            char[] marker = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            HadsupDisplay(currentPlayer);

            do
            {


                currentPlayer = GetTheNextPlayer(currentPlayer);

                next(currentPlayer);
                board(marker);

                GameEngine(marker, currentPlayer);
                gameStatus = checkWinner(marker, currentPlayer);

            } while (gameStatus.Equals(0));

            if (gameStatus.Equals(1))
            {
                board(marker);
                Console.WriteLine($"the player {currentPlayer}is the winner!!");
                Console.ReadLine();
            }
            if (gameStatus.Equals(2))
            {
                Console.WriteLine($"the game is a draw ! ");
                Console.ReadLine();
            }

        }
        private static int checkWinner(char[] marker, int currentPlayer)
        {
            if (IsGameDraw(marker))
            {
                return 2;
            }
            if (IsGameWinner(marker))

            {

                return 1;

            }
            return 0;
        }
        private static bool IsGameDraw(char[] marker)
        {
            return marker[0] != '1' &&
                marker[1] != '2' &&
               marker[2] != '3' &&
               marker[3] != '4' &&
                marker[4] != '5' &&
                marker[5] != '6' &&
                marker[6] != '7' &&
                marker[7] != '8' &&
                marker[8] != '9';
        }
        private static bool IsGameWinner(char[] marker)
        {
            if (samemarker(marker, 0, 1, 2))
            {
                return true;
            }
            if (samemarker(marker, 3, 4, 5))
            {
                return true;
            }

            if (samemarker(marker, 0, 3, 6))
            {
                return true;
            }

            if (samemarker(marker, 2, 5, 8))
            {
                return true;
            }


            if (samemarker(marker, 1, 4, 7))
            {
                return true;
            }

            if (samemarker(marker, 2, 5, 8))
            {
                return true;
            }

            if (samemarker(marker, 0, 4, 8))
            {
                return true;
            }

            if (samemarker(marker, 2, 4, 6))
            {
                return true;
            }
            return false;
        }




        private static bool samemarker(char[] testmarker, int pos1, int pos2, int pos3)
        {
            return testmarker[pos1].Equals(testmarker[pos2]) && testmarker[pos2].Equals(testmarker[pos3]);
        }
        static void board(char[] marker)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($" {marker[0]} | {marker[1]} | {marker[2]} ");
            Console.WriteLine("---+---+---",
            Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine($" {marker[3]} | {marker[4]} | {marker[5]} ");
            Console.WriteLine("---+---+---",
            Console.ForegroundColor = ConsoleColor.Magenta);
            Console.WriteLine($" {marker[6]} | {marker[7]} | {marker[8]} ");
            Console.ForegroundColor = ConsoleColor.White;




        }


        static void HadsupDisplay(int playerNumber)
        {


            string player1;
            string player2;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("welcome to the super duper tic tac toe game ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("enter your names");
            Console.WriteLine();

            Console.WriteLine("player1:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            player1 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("player2:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            player2 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("start");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
        }
        static void next(int playernumber)

        {
            for (int i = 0; i <= 2; i++)
            {





                i = playernumber;
                Console.WriteLine($"player {playernumber} to move , select 1 through from the game board");
                break;


            }

        }


        private static int GetTheNextPlayer(int player)
        {

            if (player.Equals(1))


            {
                return 2;


            }
            else
            {
                return 1;
            }

        }
        private static void GameEngine(char[] marker, int currentPlayer)
        {
            bool validMove = true;
            do
            {
                string userInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(userInput) &&
(userInput.Equals("1")) ||
                    (userInput.Equals("2")) ||
                     (userInput.Equals("3")) ||
                     (userInput.Equals("4")) ||
                     (userInput.Equals("5")) ||
                       (userInput.Equals("6")) ||
                     (userInput.Equals("7")) ||
                     (userInput.Equals("8")) ||
                     (userInput.Equals("9")))



                {

                    int.TryParse(userInput, out var gamePlacementMarker);
                    char currentMarker = marker[gamePlacementMarker - 1];
                    if (currentMarker == 'x' ||
                        currentMarker == 'o')
                    {
                        Console.WriteLine("the placment has already a marker please select another placement ");
                        board(marker);


                    }
                    else if (currentMarker != 'x' || currentMarker != 'o')
                    {
                        marker[gamePlacementMarker - 1] = GetPlayermaeker(currentPlayer);
                        validMove = false;
                    }


                    else
                    {
                        Console.WriteLine("ivalid value please select another placement");
                        board(marker);
                    }

                }
            } while (validMove);



        }


        private static char GetPlayermaeker(int player)
        {
            if (player % 2 == 0)
            {

                return 'o';
            }
            return 'x';
        }


    }
}
