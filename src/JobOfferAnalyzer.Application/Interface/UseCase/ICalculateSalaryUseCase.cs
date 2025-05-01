using JobOfferAnalyzer.Domain.Entities;
using JobOfferAnalyzer.Domain.Enums;

namespace JobOfferAnalyzer.Application.Interface.UseCase
{
    public interface ICalculateSalaryUseCase
    {
        SalaryDeductionResult Execute(decimal glossSalary, ContractType contractType);
    }
}
