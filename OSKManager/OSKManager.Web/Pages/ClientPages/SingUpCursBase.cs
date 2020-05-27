using Microsoft.AspNetCore.Components;
using OSKManager.Model;
using OSKManager.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OSKManager.Web.Pages.ClientPages
{
    public class SingUpCursBase : ComponentBase
    {
        [Inject]
        public  ICourseService CoursesService { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        protected async override Task OnInitializedAsync()
        {
            Courses = (await CoursesService.GetCourses()).ToList();

           
        }
    }
}
