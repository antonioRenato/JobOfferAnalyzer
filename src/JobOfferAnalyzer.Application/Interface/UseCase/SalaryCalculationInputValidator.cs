using FluentValidation;
using JobOfferAnalyzer.Communication.Request;
using JobOfferAnalyzer.Domain.Entities;

namespace JobOfferAnalyzer.Application.Interface.UseCase
{
    public class SalaryCalculationInputValidator : AbstractValidator<SalaryCalculationRequest> 
    {
        public SalaryCalculationInputValidator()
        {
            RuleFor(x => x.GrossSalary).GreaterThan(0).WithMessage("Gross salary must be greater than zero.");
            RuleFor(x => x.ContractType).IsInEnum().WithMessage("Invalid contract type!");
        }
    }
}
