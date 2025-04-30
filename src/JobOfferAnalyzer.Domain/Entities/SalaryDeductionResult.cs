namespace JobOfferAnalyzer.Domain.Entities
{
    public class SalaryDeductionResult
    {
        public decimal GrossSalary { get; set; }
        public decimal InssDeduction { get; set; }
        public decimal IrDeduction { get; set; }
        public decimal FgtsDeduction { get; set; }
        public decimal NetSalary { get; set; }
    }
}
