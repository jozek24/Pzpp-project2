using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Web.Model
{
    public class CalendarDay
    {
        public int DayNumber { get; set; }
        public DateTime Date { get; set; }
        public bool IsEmpty { get; set; }

        public List<CalendarEvent> Events { get; set; }
    }
}
