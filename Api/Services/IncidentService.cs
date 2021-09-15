
using Api.Interfaces;
using Api.Models;
using System.Collections.Generic;

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

        public void AddNewIncident(Incident incident)
        {
            throw new System.NotImplementedException();
        }

        public List<Incident> GetAllIncidents()
        {
            throw new System.NotImplementedException();
        }

        public Incident GetIncident(int id)
        {
            throw new System.NotImplementedException();
        }

        public Incident UpdateIncident(int incidentId)
        {
            throw new System.NotImplementedException();
        }
    }
}
