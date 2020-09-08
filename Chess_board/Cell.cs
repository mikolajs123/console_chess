using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_board
{
    public class Cell
    {
        public int rowNumber { get; set; } //numer wiersza
        public int columnNumber { get; set; } // numer kolumny

        public bool curentlyBusy { get; set; }  //pole zajete
        public bool legalMove { get; set; } // dozwolony ruch


        public Cell(int x, int y)
        {

            rowNumber = x;
            columnNumber = y;

        }


    }
}

