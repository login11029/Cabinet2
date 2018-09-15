using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    class Visit
    {
        Patient _patient;
        DateTime _date;
        string _details;

        public string Date
        {
            get { return _date.ToLongDateString(); }
            set { _date = Convert.ToDateTime(value); }
        }
        public string Details
        {
            get { return _details; }
            set { _details = value; }
        }
        public Patient Patient
        {
            get { return _patient; }
            set { _patient = value; }
        }
        public override bool Equals(object obj)
        {
            if(obj.GetType()==this.GetType())
            {
                Visit buf = (Visit)obj;
                if (buf.Date == _date.ToLongDateString() || buf.Date ==null)
                    if (buf.Details == _details || buf.Details==null)
                        return true;
            }
            return false;
        }
        public override string ToString()
        {
            string s = String.Format("{0} {1} {2} {3}", _date.ToLongDateString(), _details,_patient.Name,_patient.Surname);
            return s;
        }
        public Visit(string date,string details,Patient patient)
        {
            _details = details;
            _date = Convert.ToDateTime(date);
            _patient = patient;
        }
    }
}
