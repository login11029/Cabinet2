using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    class App
    {
        bool endProgram = false;
        Cabinet cabinet = new Cabinet();

        public void Program()
        {


            //PatientMenu.Add(new Button(1, 0, "Details", () =>
            //{
            //           ShowPatientDetails();
            //}));

            //PatientMenu.Add(new Button(1, 1, "Visit history", () =>
            //{
            //    ShowList(cabinet.CurrentPatient.GetPastVisits(), (Visit v) => { cabinet.CurrentVisit = v; VisitMenu(); });
            //}));

            //PatientMenu.Add(new Button(1, 2, "Future visits", () =>
            //{
            //    ShowList(cabinet.CurrentPatient.GetFutureVisits(), (Visit v) => { cabinet.CurrentVisit = v; VisitMenu(); });
            //}));

            //PatientMenu.Add(new Button(1, 3, "Add visit", () =>
            //{
            //    AddVisit();
            //}));

            //PatientMenu.Add(new Button(1, 4, "Back", () =>
            //{
            //    Menu.PrevMenu();
            //}));




            MainM();
            while (endProgram != true)
            {
                Menu.Action()();
            }
        }



        void MainM()
        {
            Menu.Clear();
            Menu.AddPrevMenu(MainM);
            Menu.Add(new Button(1, 0, "Add Patient", () => { AddPatient(); }));
            Menu.Add(new Button(1, 1, "Find Patient", () => { }));
            Menu.Add(new Button(1, 2, "Find Visit", () => { }));
            Menu.Add(new Button(1, 3, "Visit history", () => { }));
            Menu.Add(new Button(1, 4, "Next Visits", () => { }));
            Menu.Add(new Button(1, 5, "Patients", () => { }));
            Menu.Add(new Button(1, 7, "Exit", () => { Exit(); }));
        }





        void AddPatient()
        {
            Menu.Clear();
            Menu.AddPrevMenu(AddPatient);
            Edit name = new Edit(1, 0, "Name"); Menu.Add(name);
            Edit surname = new Edit(1, 1, "Surname"); Menu.Add(surname);
            Edit phone = new Edit(1, 2, "Phone: "); Menu.Add(phone);
            Edit details = new Edit(1, 3, "Details: "); Menu.Add(details);
            Menu.Add(new Button(1, 4, "Ok", () =>
            {
                cabinet.AddPatient(name.GetData(), surname.GetData(), phone.GetData(), details.GetData());
            }));
            Menu.Add(new Button(1, 5, "Back", () =>
            {
               Menu.PrevMenu();
            }));
        }



        //    public List<T> FindItem<T>(List<T>list, T item)
        //    {
        //        if (list.Count == 0)
        //            return list;

        //        List<T> found = new List<T>();

        //        foreach (T element in list)
        //        {
        //            if (element.Equals(item))
        //                found.Add(element);       
        //        }

        //        return found;
        //    }
        //    public void ShowList<T>(List<T>list,Action<T> a)
        //    {
        //        index = 0;
        //        ctrls.Clear();
        //        Console.Clear();

        //        ctrls.Add(new Button(1, 0, "Back", () =>
        //        {
        //            Action buf = prevMenu.ElementAt(prevMenu.Count - 1);
        //            prevMenu.RemoveAt(prevMenu.Count - 1);
        //            buf();
        //        }));

        //        for(int i=0;i<list.Count();i++)
        //        {
        //            int num = new int();
        //            num = i;

        //            ctrls.Add(new Button(1, i+1, list[i].ToString(), () => {
        //                int number = num;
        //                a(list[num]);
        //            }));
        //        }
        //    }


        //    public void AddVisit()
        //    {
        //        index = 0;
        //        ctrls.Clear();
        //        Console.Clear();

        //        Edit date = new Edit(1, 0, "Date: ");
        //        ctrls.Add(date);
        //        Edit details = new Edit(1, 1, "Details: ");
        //        ctrls.Add(details);


        //        ctrls.Add(new Button(1, 4, "Ok", () =>
        //        {
        //            cabinet.AddVisit(date.GetData(), details.GetData());
        //            PatientMenu();
        //        }));
        //        ctrls.Add(new Button(1, 5, "Back", () =>
        //        {
        //            Action buf = prevMenu.ElementAt(prevMenu.Count - 1);
        //            prevMenu.RemoveAt(prevMenu.Count - 1);
        //            buf();
        //        }));
        //    }

        //    public void FindPatient()
        //    {
        //        index = 0;
        //        ctrls.Clear();
        //        Console.Clear();

        //        Edit name = new Edit(1, 0, "Name");
        //        ctrls.Add(name);
        //        Edit surname = new Edit(1, 1, "Surname");
        //        ctrls.Add(surname);
        //        Edit phone = new Edit(1, 2, "Phone: ");
        //        ctrls.Add(phone);
        //        Edit details = new Edit(1, 3, "Details: ");
        //        ctrls.Add(details);

        //        ctrls.Add(new Button(1, 4, "Ok", () =>
        //        {
        //            prevMenu.Add(FindPatient);
        //        Patient patient = new Patient(name.GetData(), surname.GetData(), phone.GetData(), details.GetData());
        //        List<Patient> found = FindItem(cabinet.GetPatients(), patient);
        //            if (found.Count>0)
        //            {
        //                ShowList(found, (Patient p) => { cabinet.CurrentPatient = p; PatientMenu();});
        //            }
        //            else
        //            {
        //                Console.SetCursorPosition(10, 4);
        //                Console.WriteLine("Not found");
        //                index = 0;
        //            }
        //        }));

        //        ctrls.Add(new Button(1, 5, "Back", () =>
        //        {
        //            Action buf = prevMenu.ElementAt(prevMenu.Count - 1);
        //            prevMenu.RemoveAt(prevMenu.Count - 1);
        //            buf();
        //        }));
        //    }
        //    public void FindVisit()
        //    {
        //        index = 0;
        //        ctrls.Clear();
        //        Console.Clear();

        //        Edit date = new Edit(1, 0, "Date");
        //        ctrls.Add(date);
        //        Edit details = new Edit(1, 1, "Details");
        //        ctrls.Add(details);


        //        ctrls.Add(new Button(1, 4, "Ok", () =>
        //        {
        //            prevMenu.Add(FindVisit);
        //            Visit visit = new Visit(date.GetData(), details.GetData(),cabinet.CurrentPatient);
        //            List<Visit> found = FindItem(cabinet.GetVisits(), visit);
        //            if (found.Count > 0)
        //            {
        //                ShowList(found, (Visit v) => { cabinet.CurrentVisit = v; VisitMenu(); });
        //            }
        //            else
        //            {
        //                Console.SetCursorPosition(10, 4);
        //                Console.WriteLine("Not found");
        //                index = 0;
        //            }
        //        }));

        //        ctrls.Add(new Button(1, 5, "Back", () =>
        //        {
        //            Action buf = prevMenu.ElementAt(prevMenu.Count - 1);
        //            prevMenu.RemoveAt(prevMenu.Count - 1);
        //            buf();
        //        }));
        //    }

        //    public void PatientMenu()
        //    {
        //        index = 0;
        //        ctrls.Clear();
        //        Console.Clear();


        //        ctrls.Add(new Button(1, 0, "Details", () =>
        //        {
        //            ShowPatientDetails();
        //        }));

        //        ctrls.Add(new Button(1, 1, "Visit history", () =>
        //        {
        //            ShowList(cabinet.CurrentPatient.GetPastVisits(), (Visit v) => { cabinet.CurrentVisit = v; VisitMenu(); });
        //        }));

        //        ctrls.Add(new Button(1, 2, "Future visits", () =>
        //        {
        //            ShowList(cabinet.CurrentPatient.GetFutureVisits(),(Visit v)=> { cabinet.CurrentVisit = v; VisitMenu(); });
        //        }));

        //        ctrls.Add(new Button(1, 3, "Add visit", () =>
        //        {
        //            AddVisit();
        //        }));

        //        ctrls.Add(new Button(1, 4, "Back", () =>
        //        {
        //            Action buf = prevMenu.ElementAt(prevMenu.Count - 1);
        //            prevMenu.RemoveAt(prevMenu.Count - 1);
        //            buf();
        //        }));
        //    }
        //    public void ShowPatientDetails()
        //    {
        //        index = 0;
        //        ctrls.Clear();
        //        Console.Clear();

        //        Edit name = new Edit(1, 0, "Name",cabinet.CurrentPatient.Name);
        //        ctrls.Add(name);
        //        Edit surname = new Edit(1, 1, "Surname", cabinet.CurrentPatient.Surname);
        //        ctrls.Add(surname);
        //        Edit phone = new Edit(1, 2, "Phone: ", cabinet.CurrentPatient.Phone);
        //        ctrls.Add(phone);
        //        Edit details = new Edit(1, 3, "Details: ", cabinet.CurrentPatient.Details);
        //        ctrls.Add(details);

        //        ctrls.Add(new Button(1, 4, "Ok", () =>
        //        {
        //            cabinet.CurrentPatient.Name = name.GetData();
        //            cabinet.CurrentPatient.Surname = surname.GetData();
        //            cabinet.CurrentPatient.Phone = phone.GetData();
        //            cabinet.CurrentPatient.Details = details.GetData();

        //            Action buf = prevMenu.ElementAt(prevMenu.Count - 1);
        //            prevMenu.RemoveAt(prevMenu.Count - 1);
        //            buf();
        //        }));
        //    }
        //    public void VisitMenu()
        //    {
        //        index = 0;
        //        ctrls.Clear();
        //        Console.Clear();

        //        Edit date = new Edit(1, 0, "Date", cabinet.CurrentVisit.Date);
        //        ctrls.Add(date);
        //        Edit details = new Edit(1, 1, "Details", cabinet.CurrentVisit.Details);
        //        ctrls.Add(details);
        //        ctrls.Add(new Button(1,2,"Patient: "+cabinet.CurrentVisit.Patient.Name+" "+ cabinet.CurrentVisit.Patient.Surname,PatientMenu));

        //        ctrls.Add(new Button(1, 4, "Back", () =>
        //        {
        //            cabinet.CurrentVisit.Date = date.GetData();
        //            cabinet.CurrentVisit.Details = details.GetData();
        //            Action buf = prevMenu.ElementAt(prevMenu.Count - 1);
        //            prevMenu.RemoveAt(prevMenu.Count - 1);
        //            buf();
        //        }));
        //    }


        //    public void VisitHistory()
        //    {
        //        ShowList(cabinet.GetVisitsHistory(), (Visit p) => { cabinet.CurrentVisit = p; VisitMenu(); });
        //    }
        //    public void NextVisits()
        //    {
        //        ShowList(cabinet.GetFutureVisits(), (Visit p) => { cabinet.CurrentVisit = p; VisitMenu(); });
        //    }
        //    public void AllPatients()
        //    {
        //        ShowList(cabinet.GetPatients(), (Patient p) => { cabinet.CurrentPatient = p; PatientMenu(); });
        //    }


        public void Exit()
        {
            endProgram = true;
        }
        //    public void DeleteCtrl(Ctrl c)
        //    {
        //        c.Erase();
        //        ctrls.Remove(c);
        //    }


        //    public App()
        //    {
        //        endProgram = false;
        //        prevMenu = new List<Action>();
        //        ctrls = new List<Ctrl>();
        //        cabinet = new Cabinet();
        //        cursor = new Cursor();
        //        action = null;
        //        index = 0;
        //    }
        //}
    }
}






