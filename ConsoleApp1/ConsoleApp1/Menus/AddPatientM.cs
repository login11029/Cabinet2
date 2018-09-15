using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    partial class App
    {
        void AddPatient()
        {
            Edit name = new Edit(1, 0, "Name"); Menu.Add(name);
            Edit surname = new Edit(1, 1, "Surname"); Menu.Add(surname);
            Edit phone = new Edit(1, 2, "Phone: "); Menu.Add(phone);
            Edit details = new Edit(1, 3, "Details: "); Menu.Add(details);
            Menu.Add(new Button(1, 4, "Ok", () =>
            {
                cabinet.AddPatient(name.GetData(), surname.GetData(), phone.GetData(), details.GetData());
                Menu.NextMenu(PatientMenu);
            }));
            Menu.Add(new Button(1, 5, "Back", () =>
            {
                Menu.PrevMenu();
            }));
        }
    }
}
