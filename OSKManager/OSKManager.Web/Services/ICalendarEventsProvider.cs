using OSKManager.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Web.Services
{
    public interface ICalendarEventsProvider
    {

        Task<IEnumerable<CalendarEvent>> GetEventsInMonthAsync(int year, int month);

        Task AddEventAsync(CalendarEvent calendarEvent);
    }
}
