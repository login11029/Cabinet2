using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    partial class App
    {
        void NextVisits()
        {
            Menu.Add(new Button(1, 0, "Back", Menu.PrevMenu));

            int x = 1;
            int y = 1;
            List<Visit> visits = cabinet.GetFutureVisits();

            for (int i = 0; i < visits.Count(); i++)
            {
                int num = new int();
                num = i;

                Menu.Add(new Button(x, +y + i, visits[i].ToString(), () =>
                {
                    int number = num;
                    cabinet.CurrentVisit = visits[number];
                    Menu.NextMenu(VisitMenu);
                }));
            }
        }
    }
}
