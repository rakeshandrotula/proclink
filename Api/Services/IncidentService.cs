
using Api.Interfaces;

namespace Api.Services
{
    public class IncidentService : IIncidentService
    {
        private readonly ISqlService sqlService;
        private readonly IEmployeeService employeeService;
        public IncidentService(ISqlService sqlService, IEmployeeService employeeService)
        {
            this.sqlService = sqlService;
            this.employeeService = employeeService;
        }
    }
}
