using JobOfferAnalyzer.Application.Interface.Factory;
using JobOfferAnalyzer.Application.Interface.UseCase;
using JobOfferAnalyzer.Domain.Entities;
using JobOfferAnalyzer.Domain.Enums;

namespace JobOfferAnalyzer.Application.UseCases
{
    public class CalculateSalaryUseCase : ICalculateSalaryUseCase
    {
        private readonly ISalaryStrategyFactory _strategyFactory;

        public CalculateSalaryUseCase(ISalaryStrategyFactory strategyFactory)
        {
            _strategyFactory = strategyFactory;
        }

        public SalaryDeductionResult Execute(decimal glossSalary, ContractType contractType)
        {
            var strategy = _strategyFactory.Create(contractType);
            return strategy.Calculate(glossSalary);
        }
    }
}