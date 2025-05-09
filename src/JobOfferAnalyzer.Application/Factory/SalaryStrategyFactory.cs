using JobOfferAnalyzer.Application.Interface.Factory;
using JobOfferAnalyzer.Application.Interface.Strategy;
using JobOfferAnalyzer.Application.Strategy;
using JobOfferAnalyzer.Domain.Enums;

namespace JobOfferAnalyzer.Application.Factory
{
    public class SalaryStrategyFactory : ISalaryStrategyFactory
    {
        private readonly CltSalaryCalculationStrategy _cltStrategy;
        private readonly PjSalaryCalculationStrategy _pjStrategy;

        public SalaryStrategyFactory(CltSalaryCalculationStrategy cltStrategy, PjSalaryCalculationStrategy pjStrategy)
        {
            _cltStrategy = cltStrategy;
            _pjStrategy = pjStrategy;
        }

        public ISalaryCalculationStrategy Create(ContractType contractType)
        {
            return contractType switch
            {
                ContractType.CLT => _cltStrategy,
                ContractType.PJ => _pjStrategy,
                _ => throw new ArgumentException("Invalid contract type")
            };
        }
    }
}
