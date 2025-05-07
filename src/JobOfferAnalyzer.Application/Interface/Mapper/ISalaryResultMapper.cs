using JobOfferAnalyzer.Communication.Response;
using JobOfferAnalyzer.Domain.Entities;

namespace JobOfferAnalyzer.Application.Interface.Mapper
{
    public interface ISalaryResultMapper
    {
        SalaryDeductionResponse Map(SalaryDeductionResult result);
    }
}
