using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    class Cabinet
    {
        List<Patient> _patients;
        List<Visit> _visitsHistory;
        List<Visit> _visitsFuture;

        Visit _currentVisit;
        Patient _currentPatient;
   

        public void AddVisit(string date, string details)
        {
            _currentVisit = new Visit(date, details, _currentPatient);
            _visitsFuture.Add(_currentVisit);
            _currentPatient.AddVisit(_currentVisit);
        }
        public List<Patient> FindPatient(string name, string surname, string phone, string details)
        {
            List<Patient> Found = new List<Patient>();
            foreach (Patient item in _patients)
            {
                if (item.Compare(name, surname, phone, details))
                {
                    Found.Add(item);
                }
            }
            return Found;
        }
        public List<Patient>GetPatients()
        {
            return _patients;
        }
        public void AddPatient(Patient p)
        {
            _patients.Add(p);
            _currentPatient = p;
        }
        public List<Visit> GetVisitsHistory()
        {
            return _visitsHistory;
        }
        public List<Visit> GetVisits()
        {
            List<Visit> allVisits = new List<Visit>();
            foreach(Visit item in _visitsHistory)
            {
                allVisits.Add(item);
            }
            foreach (Visit item in _visitsFuture)
            {
                allVisits.Add(item);
            }
            return allVisits;
        }
        public List<Visit> GetFutureVisits()
        {
            return _visitsFuture;
        }
        public Visit CurrentVisit
        {
            get { return _currentVisit;}
            set { _currentVisit = value; }
        }
        public Patient CurrentPatient
        {
            get       {
                return _currentPatient;
            }
            set { _currentPatient = value; }
        }
        public void AddPatient(string name,string surname,string phone, string info)
        {
            _currentPatient = new Patient(name, surname, phone, info);
            _patients.Add(_currentPatient);
        }
        public Cabinet()
        {
            _patients = new List<Patient>();
            _visitsHistory = new List<Visit>();
            _visitsFuture = new List<Visit>();
        }
    }
}
