using JobOfferAnalyzer.Application.Interface.Mapper;
using JobOfferAnalyzer.Communication.Response;
using JobOfferAnalyzer.Domain.Entities;

namespace JobOfferAnalyzer.Application.Mapper
{
    public class SalaryResultMapper : ISalaryResultMapper
    {
        public SalaryDeductionResponse Map(SalaryDeductionResult result)
        {
            return new SalaryDeductionResponse
            {
                GrossSalary = result.GrossSalary,
                IrDeduction = result.IrDeduction,
                InssDeduction = result.InssDeduction,
                FgtsDeduction = result.FgtsDeduction,
                NetSalary = result.NetSalary
            };
        }
    }
}
