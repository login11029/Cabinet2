using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    class Cursor
    {
        Cords _cords;

        public void PrintCursor(Cords cords)
        {
            EraseCursor();

            _cords.X = cords.X-1;
            _cords.Y = cords.Y;

            Console.SetCursorPosition(_cords.X, _cords.Y);
            Console.Write('-');
        }
        void EraseCursor()
        {
            Console.SetCursorPosition(_cords.X, _cords.Y);
            Console.Write(' ');
        }
        public Cursor()
        {
            _cords = new Cords();
        }
    }
}
