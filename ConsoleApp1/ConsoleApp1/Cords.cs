using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    class Cords
    {
        int _x;
        int _y;

        public void SetCords(Cords cords)
        {
            _x = cords.X;
            _y = cords.Y;
        }
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
