using EMS.Entities;
using EMS.Models;
using EMS.Service.Interface;
using System.Security.Cryptography.X509Certificates;

namespace EMS.Service.Implementation
{
    public class EmployeeInfoService: IEmployeeInfoService
    {
        public EmployeeInfoService() 
        { 
            
        }
        public int GetEmployeeById(int employeeId) 
        {
            return 1;
        }
        public void SaveEmployee(EmployeeViewModel model)
        {
            EmployeeInfo employeeInfo = new EmployeeInfo();
            employeeInfo.FirstName = model.FirstName;
            employeeInfo.LastName = model.LastName;
            employeeInfo.Email = model.Email;
            employeeInfo.Gender = model.Gender;
            employeeInfo.PhoneNumber = model.PhoneNumber;
            employeeInfo.Address = model.Address;
            employeeInfo.PImage = model.PImage;
        }
        public void DeleteEmployee(int employeeId)
        {
 
        }
    }
}
