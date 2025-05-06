using JobOfferAnalyzer.Communication.Request;
using JobOfferAnalyzer.Domain.Entities;

namespace JobOfferAnalyzer.Application.Interface.UseCase
{
    public interface ICalculateSalaryUseCase
    {
        Task<SalaryDeductionResult> Execute(SalaryCalculationRequest input);
    }
}
