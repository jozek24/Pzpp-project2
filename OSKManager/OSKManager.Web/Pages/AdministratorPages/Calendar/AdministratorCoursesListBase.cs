using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Web.Pages.AdministratorPages.Calendar
{
    public class AdministratorCoursesListBase : ComponentBase
    {
        [Parameter]
        public string Name { get; set; }
    }
}
