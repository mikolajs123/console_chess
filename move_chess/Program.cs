using Chess_board;
using System;
using System.Drawing;

namespace move_chess
{
    class Program
    {
        static ChessBoardModel2 myBoard = new ChessBoardModel2(8);
        static void Main(string[] args)
        {
            //generuje pusta plansze
            printBoard(myBoard);
            
            //spytaj o cordy X Y uzytkownika gdzie chcesz polozyc pionek
            
            Cell currentCell = SetCurentCell();
            currentCell.curentlyBusy = true;

            //sprawdz wszystkie dozwolone ruchy 
            myBoard.MarkNextLegalMove(currentCell, "Rook");


            printBoard(myBoard);
            Console.ReadLine();
        }

        private static Cell SetCurentCell()
        {
            //pobierz coord X i Y z klawiatury, zwraca wartosc do class Cell 
            Console.WriteLine("Enter the current number in row");
            int currentRow = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the current number in colums");
            int currentColumn = int.Parse(Console.ReadLine());
            //bug przy wyjsciu z planszy [...] +
            //bug przy wczytwaniu stringu [...]
            //bug przy wczytywaniu zbyt duzych wartosci [...]
            //uzupelnic reszte figur[...]
            //poprawic tablice[...]
            return myBoard.theGrid[currentRow, currentColumn];

        }

        private static void printBoard(ChessBoardModel2 myBoard)
        {
            for (int k = 0; k < 1; k++)
            {
                Console.WriteLine("=========================================================="); // dopracowac [...]
            }
                //generuje szachownice w konsoli, X jako lokalizacja elementu, dla prawdiłowego ruchu, i pustych pól
                for (int i = 0; i < myBoard.Size; i++)
                {

                    for (int j = 0; j < myBoard.Size; j++)
                    {

                        Cell c = myBoard.theGrid[i, j];

                        if (c.curentlyBusy == true) { Console.Write(" ! X ! "); }
                        else if (c.legalMove == true) { Console.Write(" ! + ! "); }

                        else Console.Write(" !___! ");

                    }
                    Console.WriteLine("");
                }
            
            Console.WriteLine("==========================================================");
        }


    }
}
