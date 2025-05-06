using JobOfferAnalyzer.Communication.Request;
using Microsoft.AspNetCore.Mvc;

namespace JobOfferAnalyzer.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class JobOfferController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] SalaryCalculationRequest request)
        {
            return Ok();
        }
    }
}
