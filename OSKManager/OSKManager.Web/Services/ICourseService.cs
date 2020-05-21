using OSKManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Web.Services
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetCourses();
        Task<Course> GetCourse(Guid id);
        Task<Course> UpdateCourse(Course updatedCourse);
        Task<Course> CreateCourse(Course newCourse);
        Task DeleteCourse(Guid id);
    }
}
