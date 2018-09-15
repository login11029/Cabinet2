using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    partial class App
    {
        void MainM()
        {
            Menu.Add(new Button(1, 0, "Add Patient", () => { Menu.NextMenu(AddPatient); }));
            Menu.Add(new Button(1, 1, "Find Patient", () => { Menu.NextMenu(FindPatient); }));
            Menu.Add(new Button(1, 2, "Find Visit", () => { Menu.NextMenu(FindVisit); }));
            Menu.Add(new Button(1, 3, "Visit history", () =>
            {
                Menu.ShowList(cabinet.GetVisitsHistory(), (Visit p) => { cabinet.CurrentVisit = p; Menu.NextMenu(VisitMenu); });
            }));
            Menu.Add(new Button(1, 4, "Next Visits", () => { Menu.NextMenu(NextVisits); }));
            Menu.Add(new Button(1, 5, "Patients", () => {Menu.NextMenu(AllPatients);}));
            Menu.Add(new Button(1, 7, "Exit", () => { Exit(); }));
        }
    }
}
