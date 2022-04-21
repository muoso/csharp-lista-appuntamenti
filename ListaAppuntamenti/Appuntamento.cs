using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAgenda
{
    public class Appuntamento
    {
        private DateTime date;
        private string name;
        private string meetingPoint;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string MeetingPoint
        {
            get { return meetingPoint; }    
            set { meetingPoint = value; }
        }
        public Appuntamento(DateTime date, string name, string meetingPoint)
        {
            this.date = date;
            //Throw exception
            this.name = name;   
            this.meetingPoint = meetingPoint;
        }

        public void SetDate(DateTime date)
        {
            this.date=date;
            //Throw exception
        }

        public DateTime GetDate()
        {
            return this.date;
        }
    }
}
