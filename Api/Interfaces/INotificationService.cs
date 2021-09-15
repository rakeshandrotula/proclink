using Api.Models;
using System.Collections.Generic;

namespace Api.Interfaces
{ 
    public interface INotificationService
    {
        List<Incident> GetAllIncidentsWithoutInvestigation();
    }
}
