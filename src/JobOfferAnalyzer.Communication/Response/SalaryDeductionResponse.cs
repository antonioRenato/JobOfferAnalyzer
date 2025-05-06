namespace JobOfferAnalyzer.Communication.Response
{
    public class SalaryDeductionResponse
    {
        public decimal GrossSalary { get; set; }
        public decimal InssDeduction { get; set; }
        public decimal IrDeduction { get; set; }
        public decimal FgtsDeduction { get; set; }
        public decimal NetSalary { get; set; }
    }
}
