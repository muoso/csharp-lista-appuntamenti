using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingExceptions;

namespace PersonalAgenda
{
    public class Appuntamento
    {
        private DateTime date;
        private string name;
        private string meetingAddress;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string MeetingAddress
        {
            get { return meetingAddress; }    
            set { meetingAddress = value; }
        }
        public Appuntamento(DateTime date, string name, string meetingPoint)
        {
            this.date = date;
            if (DateTime.Now > date)
            {
                throw new DateTooOldException("La data inserita è troppo vecchia");
            }
            this.name = name;   
            this.meetingAddress = meetingPoint;
        }

        public void SetDate(DateTime date)
        {
            this.date=date;
            //Throw exception
            if (DateTime.Now > date)
            {
                throw new DateTooOldException("La data inserita è troppo vecchia");
            }
        }

        public DateTime GetDate()
        {
            return this.date;
        }

       
    }
}
