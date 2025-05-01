using JobOfferAnalyzer.Application.Interface.Strategy;
using JobOfferAnalyzer.Domain.Enums;

namespace JobOfferAnalyzer.Application.Interface.Factory
{
    public interface ISalaryStrategyFactory
    {
        ISalaryCalculationStrategy Create(ContractType contractType);
    }
}
