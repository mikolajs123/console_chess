using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Chess_board
{
    public class ChessBoardModel2
    {
        public int Size { get; set; } 

        public Cell[,] theGrid { get; set; } 

        public ChessBoardModel2(int s) 
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
        
        private bool isSafe(int x, int y) 
        { 
           
           if(x < Size && y < Size && 0 <= x && 0 <= y)
            {
                
                return true;
            }
            //Console.WriteLine("error");  <--- bug [...]
            return false;
        }
     
    
        
        public void MarkNextLegalMove(Cell currentCell, string chessPiece)
        {
            for (int f = 0; f < Size; f++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[f, j].legalMove = false;
                    theGrid[f, j].curentlyBusy = false;

                }
                switch (chessPiece)
                {
                    case "Knight":
                        if (isSafe(currentCell.rowNumber + 2, currentCell.columnNumber + 1))
                        {
                            theGrid[currentCell.rowNumber + 2, currentCell.columnNumber + 1].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber + 2, currentCell.columnNumber - 1))
                        {
                            theGrid[currentCell.rowNumber + 2, currentCell.columnNumber - 1].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber - 2, currentCell.columnNumber + 1))
                        {
                            theGrid[currentCell.rowNumber - 2, currentCell.columnNumber + 1].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber - 2, currentCell.columnNumber + 1))
                        {
                            theGrid[currentCell.rowNumber - 2, currentCell.columnNumber - 1].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber - 2, currentCell.columnNumber + 1))
                        {
                            theGrid[currentCell.rowNumber + 1, currentCell.columnNumber + 2].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber - 2, currentCell.columnNumber + 1))
                        {
                            theGrid[currentCell.rowNumber + 1, currentCell.columnNumber - 2].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber - 2, currentCell.columnNumber + 1))
                        {
                            theGrid[currentCell.rowNumber - 1, currentCell.columnNumber + 2].legalMove = true;
                        }
                        if (isSafe(currentCell.rowNumber - 2, currentCell.columnNumber + 1))
                        {
                            theGrid[currentCell.rowNumber - 1, currentCell.columnNumber - 2].legalMove = true;
                        }
                        
                            break;
                        
                    case "King":
                       
                        break;
                    case "Rook":
                        for (int i = 0; i <= Size; i++)
                        {
                            if (isSafe(currentCell.rowNumber + i, currentCell.columnNumber))
                            {
                                theGrid[currentCell.rowNumber + i, currentCell.columnNumber].legalMove = true;
                            }
                            if (isSafe(currentCell.rowNumber - i, currentCell.columnNumber))
                            {
                                theGrid[currentCell.rowNumber - i, currentCell.columnNumber].legalMove = true;
                            }
                            if (isSafe(currentCell.rowNumber, currentCell.columnNumber - i))
                            {
                                theGrid[currentCell.rowNumber, currentCell.columnNumber - i].legalMove = true;
                            }
                            if (isSafe(currentCell.rowNumber, currentCell.columnNumber + i))
                            {
                                theGrid[currentCell.rowNumber, currentCell.columnNumber + i].legalMove = true;
                            }
                        }
                            break;
                    case "Bishop":
                        break;
                    case "Queen":
                        break;

                    default:

                        break;

                }
                theGrid[currentCell.rowNumber, currentCell.columnNumber].curentlyBusy = true;
            }
            // bool ifSafe(int x, int y)
            // {
            //     ifConsole.WriteLine("error");
            //         return true;
            // }
        }


    }
}

