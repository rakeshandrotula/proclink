using Api.Interfaces;
using Api.Models;
using Api.Services;
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

        [HttpGet]
        public IActionResult GetAllIncidents()
        {
            return Ok(incidentService.GetAllIncidents());
        }

        [HttpGet]
        public IActionResult AddNewIncident(Incident incident)
        {
            try
            {
                incidentService.AddNewIncident(incident);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
