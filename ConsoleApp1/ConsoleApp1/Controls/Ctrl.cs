using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    interface Ctrl
    {
        Action Tap();
        Cords GetCords();
        string GetName();
        void Erase();
        void Print();
        void SetAction(Action a);
    }
}
