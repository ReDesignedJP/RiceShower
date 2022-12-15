using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Response;

namespace Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly ILogger _logger;
        public StatusController(ILogger<StatusController> logger)
        {
            _logger = logger;
        } //TODO get database and other status indicator

        [HttpGet]
        public async Task<IActionResult> GetAvailableServicesAsync()
        {
            GeneralResponseModel responseModel = new(new { Services = new[] { "core", "database", "rice shower" } });

            return new JsonResult(responseModel);

        }

        [Route("{service}")]
        public async Task<IActionResult> GetStatusAsync(string service)
        {
            return new JsonResult(new { Service = service, Date = DateTime.Now });
        }
    }
}
