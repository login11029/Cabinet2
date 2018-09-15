using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    partial class App
    {
        void AllPatients()
        {
            Menu.Add(new Button(1, 0, "Back", Menu.PrevMenu));

            List<Patient> all = cabinet.GetPatients();
            new CtrlList<Patient>(1, 1, all, (Patient p) => { cabinet.CurrentPatient = p; Menu.NextMenu(PatientMenu); });
        }
    }
}
