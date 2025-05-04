using FluentValidation;
using JobOfferAnalyzer.Domain.Entities;

namespace JobOfferAnalyzer.Application.Interface.UseCase
{
    public class SalaryCalculationInputValidator : AbstractValidator<SalaryCalculationInput> 
    {
        public SalaryCalculationInputValidator()
        {
            RuleFor(x => x.GrossSalary).GreaterThan(0).WithMessage("Gross salary must be greater than zero.");
            RuleFor(x => x.ContractType).IsInEnum().WithMessage("Invalid contract type!");
        }
    }
}
