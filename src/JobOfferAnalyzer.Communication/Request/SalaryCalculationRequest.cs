using JobOfferAnalyzer.Domain.Enums;

namespace JobOfferAnalyzer.Communication.Request
{
    public class SalaryCalculationRequest
    {
        public decimal GrossSalary { get; set; }
        public ContractType ContractType { get; set; }
    }
}
