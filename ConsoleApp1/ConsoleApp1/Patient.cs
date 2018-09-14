using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    class Patient
    {
        string _name;
        string _surname;
        string _phone;
        string _details;
        List<Visit> _pastVisits;
        List<Visit> _futureVisits;
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Details
        {
            get { return _details; }
            set { _details = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public override string ToString()
        {
            string s = String.Format("{0} {1} {2}", _name, _surname, _phone);
            return s;
        }
        public override bool Equals(object obj)
        {
            if(obj.GetType()==this.GetType())
            {
                Patient buf = (Patient)obj;
                if (_name == buf.Name || buf.Name == null)
                    if (_surname == buf.Surname || buf.Surname == null)
                        if (_phone == buf.Phone || buf.Phone == null)
                            if (_details == buf.Details || buf.Details == null)
                                return true;
            }
            return false;
        }
        public void AddVisit(Visit v)
        {
            _futureVisits.Add(v);
        }
        public void CheckVisit(Visit visit)
        {
            _pastVisits.Add(visit);
            _futureVisits.RemoveAt(0);
        }
        public List<Visit>GetPastVisits()
        {
            return _pastVisits;
        }
        public List<Visit> GetFutureVisits()
        {
            return _futureVisits;
        }
        public Visit GetNextVisit()
        {
            return _futureVisits.ElementAt(0);
        }
        public bool Compare(string name, string surname, string phone, string details)
        {
            if (_name == name || name == null)
                if (_surname == surname || surname == null)
                    if (_phone == phone || phone == null)
                        if (_details == details || details == null)
                            return true;

            return false;
        }
        public Patient(string name, string surname, string phone, string details)
        {
                _name = name;
                _surname = surname;
                _phone = phone;
                _details = details;

            _futureVisits = new List<Visit>();
            _pastVisits = new List<Visit>();
        }
    }
}
