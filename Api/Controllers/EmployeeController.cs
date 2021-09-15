using Api.Interfaces;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ApiControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService)
            :base(logger)
        {
            _employeeService= employeeService;
        }

        [HttpGet]
        public Employee GetEmployeeDetails(string employeeId)
        {
            return new Employee();
        }
    }
}
