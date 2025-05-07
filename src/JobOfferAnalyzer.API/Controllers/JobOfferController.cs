using JobOfferAnalyzer.Application.Interface.Mapper;
using JobOfferAnalyzer.Application.Interface.UseCase;
using JobOfferAnalyzer.Communication.Request;
using JobOfferAnalyzer.Communication.Response;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace JobOfferAnalyzer.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class JobOfferController : ControllerBase
    {
        private readonly ICalculateSalaryUseCase _useCase;
        private readonly ISalaryResultMapper _mapper;
        
        public JobOfferController(ICalculateSalaryUseCase useCase, ISalaryResultMapper mapper)
        {
            _useCase = useCase;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<SalaryDeductionResponse>> Register([FromBody] SalaryCalculationRequest request)
        {
            try
            {
                var result = await _useCase.Execute(request);

                var response = _mapper.Map(result);

                return Ok(response);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch
            {
                return StatusCode(500, "An unexpected error occurred.");
            }
        }
    }
}
