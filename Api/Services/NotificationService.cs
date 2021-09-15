
using Api.Interfaces;
using Api.Models;
using System.Collections.Generic;

namespace Api.Services
{
    public class NotificationService : INotificationService
    {
        private readonly ISqlService sqlService;
        public NotificationService(ISqlService sqlService)
        {
            this.sqlService = sqlService;
        }

        public List<Incident> GetAllIncidentsWithoutInvestigation()
        {
            throw new System.NotImplementedException();
        }
    }
}
