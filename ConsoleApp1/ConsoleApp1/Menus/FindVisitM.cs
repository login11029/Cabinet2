using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    partial class App
    {
        void FindVisit()
        {
            Edit date = new Edit(1, 0, "Date");
            Menu.Add(date);
            Edit details = new Edit(1, 1, "Details");
            Menu.Add(details);
            Menu.Add(new Button(1, 4, "Ok", () =>
            {
                Visit visit = new Visit(date.GetData(), details.GetData(), cabinet.CurrentPatient);
                List<Visit> found = FindItem(cabinet.GetVisits(), visit);
                if (found.Count > 0)
                {
                    Menu.ShowList(found, (Visit v) => { cabinet.CurrentVisit = v; Menu.NextMenu(VisitMenu); });
                }
                else
                {
                    Console.SetCursorPosition(10, 4);
                    Console.WriteLine("Not found");
                }
            }));
            Menu.Add(new Button(1, 5, "Back", () =>
            {
                Menu.PrevMenu();
            }));
        }
    }
}
