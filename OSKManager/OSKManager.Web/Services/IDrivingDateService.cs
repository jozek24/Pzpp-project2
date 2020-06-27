using OSKManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Web.Services
{
    public interface IDrivingDateService
    {
        Task<IEnumerable<DrivingDate>> GetDrivingDates();
        Task<DrivingDate> GetDrivingDate(Guid id);
        Task<DrivingDate> UpdatDrivingDate(DrivingDate updatedDrivingDate);
        Task<DrivingDate> CreateDrivingDate(DrivingDate newDrivingDate);
        Task DeleteDrivingDate(Guid id);
    }
}
