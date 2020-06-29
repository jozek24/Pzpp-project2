using Microsoft.AspNetCore.Components;
using OSKManager.Model;
using OSKManager.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Web.Pages.InstructorPages.Calendar
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public ICategoryService CategoryService { get; set; }

        public List<Category> Categories { get; set; } = new List<Category>();

        protected async override Task OnInitializedAsync()
        {
            Categories = (await CategoryService.GetCategories()).ToList();
        }
    }
}
