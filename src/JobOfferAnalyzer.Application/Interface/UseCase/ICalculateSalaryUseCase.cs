using JobOfferAnalyzer.Communication.Request;
using JobOfferAnalyzer.Domain.Entities;

namespace JobOfferAnalyzer.Application.Interface.UseCase
{
    public interface ICalculateSalaryUseCase
    {
        SalaryDeductionResult Execute(SalaryCalculationRequest input);
    }
}
