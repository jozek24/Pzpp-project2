using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using OSKManager.Model;
using OSKManager.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OSKManager.Web.Shared
{
    public class AddCourseDisplayBase : ComponentBase

    {

        [Inject]
        public ICategoryService CategoryService { get; set; }
        [Inject]
        public ICourseService CourseService { get; set; }
        public List<Category> CategoryList { get; set; }
        public List<Course> CourseList { get; set; }
        public string ShortCategory;
        public string lectureText;
        public string driveText;
        public string priceText;
        protected Course Course = new Course();
        [Parameter]
        public Category Category { get; set; }

        protected async override Task OnInitializedAsync()
        {

            CategoryList = (await CategoryService.GetCategories()).ToList();
            ShortCategory = Category.ShortCategory;

        }
        protected void CourseDetails()
        {
            int price =  Decimal.ToInt32(Category.BasicPrice);
           
           
            lectureText = "Teoria: " + Category.CountOfLectureHours + " godz.";
            driveText = "Praktyka: " + Category.CountOfDrivingHours + " godz.";
            priceText = "Cena: " + price + " zł.";
          
        }
        protected async Task SingUpCourse()
        {
            Course course = new Course();
            //course.Category = Category;
            course.ActualPrice = Category.BasicPrice;
            course.CategoryId = Category.Id;
            course.FinishedDrivingHours = 0;
            course.FinishedLectureHours = 0;
            course.IsStarted = false;
            course.Name = Category.LongCategoryName;
            course.Id = Guid.NewGuid();
            
         await   CourseService.CreateCourse(course);
        }
    }
}

