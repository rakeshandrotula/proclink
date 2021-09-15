
using Api.Interfaces;
using Api.Models;

namespace Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ISqlService sqlService;
        public EmployeeService(ISqlService sqlService)
        {
            this.sqlService = sqlService;
        }

        public Employee GetEmployeeDetails(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
