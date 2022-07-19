using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardChallengeSolution
{
    public class Board
    {
        public int Size { get; set; }   //8x8
        public Cell[,] theGrid { get; set; }

        public Board(int s)
        {
            Size = s;
            theGrid = new Cell[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }
        public bool isSafe(int x, int y)
        {
            if (x < 0 || x >= Size || y < 0 || y >= Size)
            {
                return false;
            }
            else return true;
        }
        public void MarkNextLegalMoves(Cell currentcell, string chessPiece)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                    theGrid[i, j].CurrentlyOccupied = false;
                }
            }
            switch (chessPiece)
            {
                case "Knight":
                    if (isSafe(currentcell.RowNumber + 2, currentcell.ColumnNumber + 1))
                        theGrid[currentcell.RowNumber + 2, currentcell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentcell.RowNumber + 1, currentcell.ColumnNumber + 2))
                    theGrid[currentcell.RowNumber + 1, currentcell.ColumnNumber + 2].LegalNextMove = true;

                    if (isSafe(currentcell.RowNumber - 2, currentcell.ColumnNumber - 1))
                        theGrid[currentcell.RowNumber -2, currentcell.ColumnNumber -1].LegalNextMove = true;

                        if (isSafe(currentcell.RowNumber - 1, currentcell.ColumnNumber - 2))
                        theGrid[currentcell.RowNumber - 1, currentcell.ColumnNumber - 2].LegalNextMove = true;

                            if (isSafe(currentcell.RowNumber + 2, currentcell.ColumnNumber - 1))
                        theGrid[currentcell.RowNumber +2, currentcell.ColumnNumber - 1].LegalNextMove = true;

                                if (isSafe(currentcell.RowNumber + 1, currentcell.ColumnNumber - 2))
                        theGrid[currentcell.RowNumber + 1, currentcell.ColumnNumber - 2].LegalNextMove = true;

                                    if (isSafe(currentcell.RowNumber - 2, currentcell.ColumnNumber + 1))
                        theGrid[currentcell.RowNumber -2, currentcell.ColumnNumber +1].LegalNextMove = true;

                                        if (isSafe(currentcell.RowNumber - 1, currentcell.ColumnNumber + 2))
                        theGrid[currentcell.RowNumber - 1, currentcell.ColumnNumber + 2].LegalNextMove = true;
                    break;

                case "King":
                    if(isSafe( currentcell.RowNumber + 1, currentcell.ColumnNumber))
                    theGrid[currentcell.RowNumber + 1, currentcell.ColumnNumber ].LegalNextMove = true;

                    if(isSafe( currentcell.RowNumber + 1, currentcell.ColumnNumber + 1))
                    theGrid[currentcell.RowNumber + 1, currentcell.ColumnNumber + 1].LegalNextMove = true;

                    if (isSafe(currentcell.RowNumber + 1, currentcell.ColumnNumber - 1))
                        theGrid[currentcell.RowNumber + 1, currentcell.ColumnNumber - 1].LegalNextMove = true;

                    if (isSafe(currentcell.RowNumber, currentcell.ColumnNumber - 1))
                        theGrid[currentcell.RowNumber , currentcell.ColumnNumber - 1].LegalNextMove = true;

                    if (isSafe(currentcell.RowNumber, currentcell.ColumnNumber + 1))
                        theGrid[currentcell.RowNumber , currentcell.ColumnNumber + 1].LegalNextMove = true;

                    if (isSafe(currentcell.RowNumber - 1, currentcell.ColumnNumber - 1))
                        theGrid[currentcell.RowNumber - 1, currentcell.ColumnNumber - 1].LegalNextMove = true;

                    if (isSafe(currentcell.RowNumber - 1, currentcell.ColumnNumber))
                        theGrid[currentcell.RowNumber - 1, currentcell.ColumnNumber ].LegalNextMove = true;

                    if (isSafe(currentcell.RowNumber - 1, currentcell.ColumnNumber + 1))
                        theGrid[currentcell.RowNumber - 1, currentcell.ColumnNumber + 1].LegalNextMove = true;

                    break;
                case "Rook":
                    for (int i = 0; i < 8; i++)
                    {
                        if (isSafe(currentcell.RowNumber - i, currentcell.ColumnNumber))
                            theGrid[currentcell.RowNumber - i, currentcell.ColumnNumber].LegalNextMove = true;

                        if (isSafe(currentcell.RowNumber +i , currentcell.ColumnNumber))
                            theGrid[currentcell.RowNumber + i, currentcell.ColumnNumber].LegalNextMove = true;

                        if (isSafe(currentcell.RowNumber , currentcell.ColumnNumber - i))
                            theGrid[currentcell.RowNumber , currentcell.ColumnNumber - i].LegalNextMove = true;

                        if (isSafe(currentcell.RowNumber , currentcell.ColumnNumber + i))
                            theGrid[currentcell.RowNumber , currentcell.ColumnNumber + i].LegalNextMove = true;
                    }
                    
                    break;
                case "Bishop":

                    for (int i = 0; i < 8; i++)
                    {
                        if (isSafe(currentcell.RowNumber - i, currentcell.ColumnNumber - i))
                            theGrid[currentcell.RowNumber - i, currentcell.ColumnNumber - i].LegalNextMove = true;

                        if (isSafe(currentcell.RowNumber + i, currentcell.ColumnNumber + i))
                            theGrid[currentcell.RowNumber + i, currentcell.ColumnNumber + i].LegalNextMove = true;

                        if (isSafe(currentcell.RowNumber + i, currentcell.ColumnNumber - i))
                            theGrid[currentcell.RowNumber + i, currentcell.ColumnNumber - i].LegalNextMove = true;

                        if (isSafe(currentcell.RowNumber - i, currentcell.ColumnNumber + i))
                            theGrid[currentcell.RowNumber - i, currentcell.ColumnNumber + i].LegalNextMove = true;

                    }

                    break;
                case "Queen":

                    for (int i = 0; i < 8; i++)
                    {
                        if (isSafe(currentcell.RowNumber - i, currentcell.ColumnNumber - i))
                            theGrid[currentcell.RowNumber - i, currentcell.ColumnNumber - i].LegalNextMove = true;

                        if (isSafe(currentcell.RowNumber + i, currentcell.ColumnNumber + i))
                            theGrid[currentcell.RowNumber + i, currentcell.ColumnNumber + i].LegalNextMove = true;

                        if (isSafe(currentcell.RowNumber + i, currentcell.ColumnNumber - i))
                            theGrid[currentcell.RowNumber + i, currentcell.ColumnNumber - i].LegalNextMove = true;

                        if (isSafe(currentcell.RowNumber - i, currentcell.ColumnNumber + i))
                            theGrid[currentcell.RowNumber - i, currentcell.ColumnNumber + i].LegalNextMove = true;

                        if (isSafe(currentcell.RowNumber - i, currentcell.ColumnNumber))
                            theGrid[currentcell.RowNumber - i, currentcell.ColumnNumber].LegalNextMove = true;

                        if (isSafe(currentcell.RowNumber + i, currentcell.ColumnNumber))
                            theGrid[currentcell.RowNumber + i, currentcell.ColumnNumber].LegalNextMove = true;

                        if (isSafe(currentcell.RowNumber, currentcell.ColumnNumber - i))
                            theGrid[currentcell.RowNumber, currentcell.ColumnNumber - i].LegalNextMove = true;

                        if (isSafe(currentcell.RowNumber, currentcell.ColumnNumber + i))
                            theGrid[currentcell.RowNumber, currentcell.ColumnNumber + i].LegalNextMove = true;

                    }
                    break;
            }
            theGrid[currentcell.RowNumber, currentcell.ColumnNumber].CurrentlyOccupied = true;
        }

    }
}
