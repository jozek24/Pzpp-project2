using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Web.Areas.Administrator.Pages
{
    public class CalendarBase : ComponentBase
    {
        public bool ShowFooter { get; set; } = true;

        public int Days { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Days = DateTime.DaysInMonth(2020, 5);
        }
    }
}
