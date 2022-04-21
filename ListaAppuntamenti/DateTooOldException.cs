using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingExceptions
{
    public class DateTooOldException : Exception
    {
        public DateTooOldException(string message) : base(message)
        {

        }
    }
}
