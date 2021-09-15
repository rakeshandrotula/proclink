
using Api.Interfaces;

namespace Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ISqlService sqlService;
        public EmployeeService(ISqlService sqlService)
        {
            this.sqlService = sqlService;
        }
    }
}
