using Api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IncidentController : ApiControllerBase
    {
       private readonly IIncidentService incidentService;
        public IncidentController(ILogger<EmployeeController> logger, IIncidentService incidentService)
            : base(logger)
        {
            this.incidentService = incidentService;
        }
    }
}
