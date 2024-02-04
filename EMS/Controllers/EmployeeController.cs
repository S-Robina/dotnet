using EMS.Models;
using EMS.Service.Implementation;
using EMS.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    
    public class EmployeeController : Controller
    {
        public readonly IEmployeeInfoService _iEmployeeInfoService;
        public EmployeeController(IEmployeeInfoService iEmployeeInfoService)
        {
            this._iEmployeeInfoService = iEmployeeInfoService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeViewModel model)
        {
            return View();
        }
        
    }
}
