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
                gameStatus = checkWinner(marker);

            } while (gameStatus.Equals(0));



        }
        private static int checkWinner(char[] marker)
        { if (marker[0].Equals(marker[1]) && marker[1].Equals(marker[2]))
            { return 1;
            }
            return 0;
        }
        public static void board(char[] marker)
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
            
            
                
                Console.WriteLine($"player{playerNumber} to move , select 1 through from the game board");
                Console.WriteLine();
        }
        static void next(int playernumber)

        {
            for (int i = 0; i <= 2; i++)
            {
                if (playernumber != 1)



                {
                    i = playernumber;
                    Console.WriteLine($"player {playernumber} to move , select 1 through from the game board");
                    break;
                }

            }

        }
           

        static int GetTheNextPlayer(int player)
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
            

} } 
