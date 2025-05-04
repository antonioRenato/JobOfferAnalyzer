using JobOfferAnalyzer.Domain.Enums;

namespace JobOfferAnalyzer.Domain.Entities
{
    public class SalaryCalculationInput
    {
        public decimal GrossSalary { get; set; }
        public ContractType ContractType { get; set; }
    }
}
