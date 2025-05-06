using FluentValidation;
using JobOfferAnalyzer.Application.Interface.Factory;
using JobOfferAnalyzer.Application.Interface.UseCase;
using JobOfferAnalyzer.Communication.Request;
using JobOfferAnalyzer.Domain.Entities;

namespace JobOfferAnalyzer.Application.UseCases
{
    public class CalculateSalaryUseCase : ICalculateSalaryUseCase
    {
        private readonly ISalaryStrategyFactory _strategyFactory;
        private readonly IValidator<SalaryCalculationRequest> _validator;

        public CalculateSalaryUseCase(ISalaryStrategyFactory strategyFactory,
                                      IValidator<SalaryCalculationRequest> validator)
        {
            _strategyFactory = strategyFactory;
            _validator = validator;
        }

        public async Task<SalaryDeductionResult> Execute(SalaryCalculationRequest input)
        {
            var result = _validator.Validate(input);

            if (!result.IsValid)
                throw new ValidationException(result.Errors);

            var strategy = _strategyFactory.Create(input.ContractType);
            return strategy.Calculate(input.GrossSalary);
        }
    }
}