using JobOfferAnalyzer.Domain.Entities;

namespace JobOfferAnalyzer.Application.Interface.Strategy
{
    public interface ISalaryCalculationStrategy
    {
        SalaryDeductionResult Calculate(decimal grossSalary);
    }
}
