using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    partial class App
    {
        void ShowPatientDetails()
        {

            Edit name = new Edit(1, 0, "Name", cabinet.CurrentPatient.Name);
            Menu.Add(name);
            Edit surname = new Edit(1, 1, "Surname", cabinet.CurrentPatient.Surname);
            Menu.Add(surname);
            Edit phone = new Edit(1, 2, "Phone: ", cabinet.CurrentPatient.Phone);
            Menu.Add(phone);
            Edit details = new Edit(1, 3, "Details: ", cabinet.CurrentPatient.Details);
            Menu.Add(details);
            Menu.Add(new Button(1, 4, "Ok", () =>
            {
                cabinet.CurrentPatient.Name = name.GetData();
                cabinet.CurrentPatient.Surname = surname.GetData();
                cabinet.CurrentPatient.Phone = phone.GetData();
                cabinet.CurrentPatient.Details = details.GetData();

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
