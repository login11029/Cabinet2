using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    partial class App
    {
        void FindPatient()
        {
            Edit name = new Edit(1, 0, "Name");
            Menu.Add(name);
            Edit surname = new Edit(1, 1, "Surname");
            Menu.Add(surname);
            Edit phone = new Edit(1, 2, "Phone: ");
            Menu.Add(phone);
            Edit details = new Edit(1, 3, "Details: ");
            Menu.Add(details);
            Menu.Add(new Button(1, 4, "Ok", () =>
            {
                Patient patient = new Patient(name.GetData(), surname.GetData(), phone.GetData(), details.GetData());
                List<Patient> found = FindItem(cabinet.GetPatients(), patient);
                if (found.Count > 0)
                {
                    Menu.ShowList(found, (Patient p) => { cabinet.CurrentPatient = p; Menu.NextMenu(PatientMenu); });
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
