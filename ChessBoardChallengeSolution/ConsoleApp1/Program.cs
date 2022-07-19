using ChessBoardChallengeSolution;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static Board myBoard = new Board(8);

        static void Main(string[] args)
        {
            printBoard(myBoard);
            Cell currentCell = setCurrentCell();          
            currentCell.CurrentlyOccupied = true;
            myBoard.MarkNextLegalMoves(currentCell, setPiece());
            printBoard(myBoard);
        }

        private static Cell setCurrentCell()
        {
            Console.WriteLine("Enter the current row number");
            int currentRow = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the current column number");
            int currentColumn = int.Parse(Console.ReadLine());

          

            return myBoard.theGrid[currentRow, currentColumn];
        }
        private static string setPiece()
        {
            Console.WriteLine("What kind of chess piece would you like to place on the board? Knight, King, Queen, Bishop, Rook");
            string piece = Console.ReadLine();
            return piece;
        }


        //private static void printBoard(Board myBoard)
        //{
        //    for (int i = 0; i < myBoard.Size; i++)
        //    {
        //        for (int j = 0; j < myBoard.Size; j++)
        //        {
        //            Cell c = myBoard.theGrid[i, j];

        //            if (c.CurrentlyOccupied == true)
        //            {
        //                Console.Write("X");
        //            }
        //            else if (c.LegalNextMove == true)
        //            {
        //                Console.Write("+");
        //            }
        //            else
        //            {
        //                Console.Write(".");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine("=======================");

        //}

        private static void printBoard(Board myBoard)
        {
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int b = 0; b < myBoard.Size; b++)
                {
                    Console.Write("+---");
                }
                Console.Write("+");
                Console.WriteLine();
                Console.Write("| ");
                for (int j = 0; j < myBoard.Size; j++)
                {


                    Cell c = myBoard.theGrid[i, j];

                    if (c.CurrentlyOccupied == true)
                    {
                        Console.Write("X");
                    }
                    else if (c.LegalNextMove == true)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" | ");
                }
                Console.WriteLine();

            }
            for (int d = 0; d < myBoard.Size; d++)
            {
                Console.Write("+---");
            }
            Console.Write("+");
            Console.WriteLine();
            Console.WriteLine("=======================");

        }
    }
}
