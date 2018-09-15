using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    partial class App
    {
        void VisitHistory()
        {
            Menu.ShowList(cabinet.GetVisitsHistory(), (Visit p) => { cabinet.CurrentVisit = p; Menu.NextMenu(VisitMenu); });
        }
    }
}
