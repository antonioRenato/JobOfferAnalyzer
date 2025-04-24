namespace JobOfferAnalyzer.Application.Interface
{
    public interface ICalcIrServices
    {
        decimal ComputeBaseIr(decimal salary, decimal baseInss);
        decimal ComputeDeductionIR(decimal baseIr);
    }
}
