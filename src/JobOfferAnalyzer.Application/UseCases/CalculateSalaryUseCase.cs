using FluentValidation;
using JobOfferAnalyzer.Application.Interface.Factory;
using JobOfferAnalyzer.Application.Interface.UseCase;
using JobOfferAnalyzer.Domain.Entities;
using JobOfferAnalyzer.Domain.Enums;

namespace JobOfferAnalyzer.Application.UseCases
{
    public class CalculateSalaryUseCase : ICalculateSalaryUseCase
    {
        private readonly ISalaryStrategyFactory _strategyFactory;
        private readonly IValidator<SalaryCalculationInput> _validator;

        public CalculateSalaryUseCase(ISalaryStrategyFactory strategyFactory,
                                      IValidator<SalaryCalculationInput> validator)
        {
            _strategyFactory = strategyFactory;
            _validator = validator;
        }

        public SalaryDeductionResult Execute(SalaryCalculationInput input)
        {
            var result = _validator.Validate(input);

            if (!result.IsValid)
                throw new ValidationException(result.Errors);

            var strategy = _strategyFactory.Create(input.ContractType);
            return strategy.Calculate(input.GrossSalary);
        }
    }
}