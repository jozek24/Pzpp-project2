using OSKManager.Web.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Web.Model
{
    public class CalendarEvent
    {

        public CalendarEvent()
        {
            Color = RandomColorHelper.GetRandomColorClass();
        }

        public string Subject { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Color { get; private set; }
    }
}
