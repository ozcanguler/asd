using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class KnightsTour
    {
        static int boardSize = 5;
        static int attemptedMoves = 0;
        static int[] xMoves = { 2, 2, -2, -2, 1, -1, -1, 1 };
        static int[] yMoves = { 1, -1, -1, 1, 2, 2, -2, -2 };
        static int[,] boardGrid = new int[boardSize, boardSize];
       
       public static void solveKT()  //initialize all squares to not visited.
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    boardGrid[i, j] = -1;   //set initial value to -1. not visited status.
                }
            }

            // initialize starting point, number of moves
            int startX = 0;
            int startY = 0;
            boardGrid[startX, startY] = 0;
            attemptedMoves = 0;

            //recursively try all possible legal moves. Backtrack on dead end solutions.
            if (!solveKTUtil(startX, startY, 1))
            {

                Console.WriteLine("No solution found for {0} {1}", startX, startY);
            }
            else
            {
                printBoard(boardGrid);
                Console.WriteLine("Total attempted moves {0}", attemptedMoves);
            }
            bool solveKTUtil(int x, int y, int moveCount)
            {

                attemptedMoves++;
                if (attemptedMoves % 10000000 == 0)
                {

                    Console.WriteLine("Attempted {0} moves", attemptedMoves);
                }
              
                int k; //counter for moving through the nextX and nextY arrays.
                int next_x, next_y; //location for the next move in the recursion.

                // check to see if we have solved the game.
                if (moveCount == boardSize * boardSize)
                {

                    return true;
                }
                //cycle through all of the possible next moves for the knight.
                for (k = 0; k < 8; k++)
                {
                    next_x = x + xMoves[k];
                    next_y = y + yMoves[k];
                    if (safeSquare(next_x, next_y))
                    {
                        boardGrid[next_x, next_y] = moveCount;
                        if (solveKTUtil(next_x, next_y, moveCount + 1))
                        {
                            return true;
                        }
                        else
                        {
                            boardGrid[next_x, next_y] = -1;
                        }
                    }
                }
                return false;
            }
            bool safeSquare(int x, int y)
            //check to see if x, y is on the board. no out of bouds index errors wanted.
            // also check to see if the square is visited or not.
            {
                return (x >= 0 && x < boardSize && y >= 0 && y < boardSize && boardGrid[x, y] == -1);

            }
            void printBoard(int[,] boardToPrint)
            {
                for (int i = 0; i < boardSize; i++)
                {
                    for (int j = 0; j < boardSize; j++)
                    {
                        if (boardGrid[i, j] < 10)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(boardGrid[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

        }


    }
}
