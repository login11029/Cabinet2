using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    partial class App
    {
        void VisitMenu()
        {

            Edit date = new Edit(1, 0, "Date", cabinet.CurrentVisit.Date);
            Menu.Add(date);
            Edit details = new Edit(1, 1, "Details", cabinet.CurrentVisit.Details);
            Menu.Add(details);
            Menu.Add(new Button(1, 2, "Patient: " + cabinet.CurrentVisit.Patient.Name + " " + cabinet.CurrentVisit.Patient.Surname, () =>
            {
                Menu.NextMenu(PatientMenu);
            }));
            Menu.Add(new Button(1, 4, "Ok", () =>
            {
                cabinet.CurrentVisit.Date = date.GetData();
                cabinet.CurrentVisit.Details = details.GetData();
                Menu.Refresh();
                Console.SetCursorPosition(10, 4);
                Console.WriteLine("Saved");
            }));
            Menu.Add(new Button(1, 5, "Back", () =>
            {
                Menu.PrevMenu();
            }));
        }
    }
}
