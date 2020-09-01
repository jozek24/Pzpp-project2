using Microsoft.AspNetCore.Components;
using Microsoft.CodeAnalysis.CSharp;
using OSKManager.Components;
using OSKManager.Model;
using OSKManager.Web.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace OSKManager.Web.Pages.AdministratorPages.Calendar
{

    public class Des
    {
        public Season Season { get; set; }
        public EnumCategory EnumCategory { get; set; }
    }

    public enum Season
    {
        [LocalizedDescription("Wykład", typeof(ResourceAttributes))]
        Wyklad,
        [LocalizedDescription("Jazdy", typeof(ResourceAttributes))]
        Jazdy
    }

    public enum EnumCategory
    {

    }


    public class AdministratorAddEventBase : ComponentBase
    {


        public Des des = new Des();
        public Category category = new Category();

        [Inject]
        public ICategoryService CategoryService { get; set; }
        [Inject]
        public ICourseService CourseService { get; set; }

        public List<Category> Categories { get; set; } = new List<Category>();
        public Category Category { get; set; } = new Category();
        public string Activity { get; set; } = "";
        public string[] Activities { get; set; } = { "Wykład", "Egzamin wewnętrzny" };
        public Course Course { get; set; } = new Course();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Course> ListOfCourses { get; set; }
        public Student Student { get; set; } = new Student();
        public List<Student> Students { get; set; } = new List<Student>();

        public string MyProperty { get; set; } = "";

        public List<Course> SampleCourses { get; set; } 

        public IEnumerable<EnumCategory> EnumCategory { get; set; }


        protected async override Task OnInitializedAsync()
        {
            Categories = (await CategoryService.GetCategories()).OrderBy(x => x.ShortCategory).ToList();
            Courses = (await CourseService.GetCourses()).OrderBy(x => x.Name).ToList();

            if (Categories != null)
            {
                Category = Categories[0];

                EnumCategory = Categories.Select(x => x.ShortCategory).ToList()
                    .Select(y => EnumExtensions.GetValueFromDescription<EnumCategory>(y));

            }

            SampleCourses = new List<Course>()
            {
                new Course{ Name = "kurs B", Category = new Category{ ShortCategory = "B"}  },
                new Course{ Name = "kurs C", Category = new Category{ ShortCategory = "C"}  }
            };
        }

        private void FilterChangedAsync(ChangeEventArgs args)
        {
            MyProperty = args.Value.ToString();
        }

        public Task OnValueChanged(string value)
        {
            // Assign the selected value to the Model 
            Category.ShortCategory = value;
            ListOfCourses = null;
            GetActiveCourses(value);
            return Task.CompletedTask;
        }
        private void GetActiveCourses(string shortCategory)
        {
            ListOfCourses = SampleCourses.Where(x => x.Category.ShortCategory == shortCategory).ToList();
        }

        public Task OnValueChangedCourses(string value)
        {
            return Task.CompletedTask;
        }
    }
}
