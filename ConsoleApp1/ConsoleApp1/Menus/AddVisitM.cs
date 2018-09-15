using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    partial class App
    {
        void AddVisit()
        {
            Edit date = new Edit(1, 0, "Date: ");
            Menu.Add(date);
            Edit details = new Edit(1, 1, "Details: ");
            Menu.Add(details);
            Menu.Add(new Button(1, 4, "Ok", () =>
            {
                cabinet.AddVisit(date.GetData(), details.GetData());
                Menu.PrevMenu();
            }));
            Menu.Add(new Button(1, 5, "Back", () =>
            {
                Menu.PrevMenu();
            }));
        }
    }
}
