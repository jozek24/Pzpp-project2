using OSKManager.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Web.Services
{
    public interface IWorkClassService
    {
        Task<IEnumerable<WorkClass>> GetWorkClasses();
        Task<WorkClass> GetWorkClass(Guid id);
        Task<WorkClass> UpdateWorkClass(WorkClass updatedWorkClass);
        Task<WorkClass> CreateWorkClass(WorkClass newWorkClass);
        Task DeleteWorkClass(Guid id);
    }
}
