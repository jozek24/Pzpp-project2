using Microsoft.AspNetCore.Components;
using OSKManager.Model;
using OSKManager.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Web.Pages.ClientPages.Components
{
    public class AddCourseFormBase: ComponentBase
    {
        [Inject]
        public ICategoryService CategoryService { get; set; }
        public List<Category> CategoryList { get; set; }
        [Inject]
        public ICourseService CourseService { get; set; }
    }
}
