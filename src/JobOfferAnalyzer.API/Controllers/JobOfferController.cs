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
        
        public JobOfferController(ICalculateSalaryUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpPost]
        public async Task<ActionResult<SalaryDeductionResponse>> Register([FromBody] SalaryCalculationRequest request)
        {
            try
            {
                var result = await _useCase.Execute(request);

                var response = new SalaryDeductionResponse
                {
                    InssDeduction = result.InssDeduction,
                    IrDeduction = result.IrDeduction,
                    FgtsDeduction = result.FgtsDeduction,
                    NetSalary = result.NetSalary
                };

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
