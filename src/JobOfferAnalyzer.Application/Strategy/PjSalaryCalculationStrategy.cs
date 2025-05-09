using JobOfferAnalyzer.Application.Interface.Strategy;
using JobOfferAnalyzer.Domain.Entities;

namespace JobOfferAnalyzer.Application.Strategy
{
    public class PjSalaryCalculationStrategy : ISalaryCalculationStrategy
    {        
        public SalaryDeductionResult Calculate(decimal grossSalary)
        {
            return new SalaryDeductionResult
            {
                GrossSalary = grossSalary,
                InssDeduction = 0,
                IrDeduction = 0,
                FgtsDeduction = 0,
                NetSalary = grossSalary
            };
        }
    }
}
