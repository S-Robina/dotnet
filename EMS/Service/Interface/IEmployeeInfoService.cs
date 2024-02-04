using EMS.Models;

namespace EMS.Service.Interface
{
    public interface IEmployeeInfoService 
    {
        int GetEmployeeById(int employeeId);
        void SaveEmployee(EmployeeViewModel model);
        void DeleteEmployee(int employeeId);
    }
}
