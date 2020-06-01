using Microsoft.AspNetCore.Components;
using OSKManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OSKManager.Web.Services
{
    public class CourseService : ICourseService
    {
        private readonly HttpClient httpClient;

        public CourseService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Course> CreateCourse(Course newCourse)
        {
            return await httpClient.PostJsonAsync<Course>("api/courses", newCourse);
        }

        public async Task DeleteCourse(Guid id)
        {
            await httpClient.DeleteAsync($"api/courses/{id}");
        }

        public async Task<Course> GetCourse(Guid id)
        {
            return await httpClient.GetJsonAsync<Course>($"api/courses/{id}");
        }

        public async Task<IEnumerable<Course>> GetCourses()
        {
            return await httpClient.GetJsonAsync<Course[]>("api/courses");
        }

        public async Task<Course> UpdateCourse(Course updatedCourse)
        {
            return await httpClient.PutJsonAsync<Course>("api/courses", updatedCourse);
        }
    }
}
