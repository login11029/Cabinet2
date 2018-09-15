using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    partial class App
    {
        void PatientMenu()
        {
            Menu.Add(new Button(1, 0, "Details", () =>
            {
                Menu.NextMenu(ShowPatientDetails);
            }));
            Menu.Add(new Button(1, 1, "Visit history", () =>
            {
                Menu.ShowList(cabinet.CurrentPatient.GetPastVisits(), (Visit v) =>
                {
                    cabinet.CurrentVisit = v; Menu.NextMenu(VisitMenu);
                });
            }));
            Menu.Add(new Button(1, 2, "Future visits", () =>
            {
                Menu.ShowList(cabinet.CurrentPatient.GetFutureVisits(), (Visit v) =>
                {
                    cabinet.CurrentVisit = v; Menu.NextMenu(VisitMenu);
                });
            }));
            Menu.Add(new Button(1, 3, "Add visit", () =>
            {
                Menu.NextMenu(AddVisit);
            }));
            Menu.Add(new Button(1, 4, "Back", () =>
            {
                Menu.PrevMenu();
            }));
        }
    }
}
