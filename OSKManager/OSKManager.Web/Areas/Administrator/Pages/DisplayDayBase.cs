using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Web.Areas.Administrator.Pages
{
    public class DisplayDayBase : ComponentBase
    {
        [Parameter]
        public bool ShowFooter { get; set; }
    }
}
