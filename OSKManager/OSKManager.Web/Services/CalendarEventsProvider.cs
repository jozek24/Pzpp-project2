using Newtonsoft.Json;
using OSKManager.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OSKManager.Web.Services
{
    public class CalendarEventsProvider : ICalendarEventsProvider
    {

        private readonly HttpClient _httpClient;

        private const string BASE_URL = "https://graph.microsoft.com/v1.0/me/events";

        public CalendarEventsProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CalendarEvent>> GetEventsInMonthAsync(int year, int month)
        {

            // 3-  Send the request 
            var response = await _httpClient.GetAsync(ConstructGraphUrl(year, month));

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            // 4- Read the content 
            var contentAsString = await response.Content.ReadAsStringAsync();

            var microsoftEvents = JsonConvert.DeserializeObject<GraphEventsResponse>(contentAsString);

            // Convert the Microsoft Event object into CalendarEvent object
            var events = new List<CalendarEvent>();
            foreach (var item in microsoftEvents.Value)
            {
                events.Add(new CalendarEvent
                {
                    Subject = item.Subject,
                    StartDate = item.Start.ConvertToLocalDateTime(),
                    EndDate = item.End.ConvertToLocalDateTime()
                });
            }

            return events;
        }

        public async Task AddEventAsync(CalendarEvent calendarEvent)
        {

            // 3- Initialize the content of the post request 
            string eventAsJson = JsonConvert.SerializeObject(new MicrosoftGraphEvent
            {
                Subject = calendarEvent.Subject,
                Start = new DateTimeTimeZone
                {
                    DateTime = calendarEvent.StartDate.ToString(),
                    TimeZone = TimeZoneInfo.Local.Id
                },
                End = new DateTimeTimeZone
                {
                    DateTime = calendarEvent.EndDate.ToString(),
                    TimeZone = TimeZoneInfo.Local.Id,
                }
            });

            var content = new StringContent(eventAsJson);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            // Send the request
            var response = await _httpClient.PostAsync(BASE_URL, content);

            if (response.IsSuccessStatusCode)
                Console.WriteLine("Event has been added successfully!");
            else
                Console.WriteLine(response.StatusCode);
        }

        

        private string ConstructGraphUrl(int year, int month)
        {
            return $"{BASE_URL}?$filter=start/datetime ge '{year}-{month}-01T00:00' and end/dateTime le '{year}-{month}-31T00:00'&$select=subject,start,end";
        }
    }
}
