using Api.Models;
using System.Collections.Generic;

namespace Api.Interfaces
{
    public interface IIncidentService
    {
        void AddNewIncident(Incident incident);
        Incident UpdateIncident(int incidentId);
        List<Incident> GetAllIncidents();
        Incident GetIncident(int id);
    }
}
