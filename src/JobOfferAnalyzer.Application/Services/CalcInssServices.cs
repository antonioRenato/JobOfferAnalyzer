using JobOfferAnalyzer.Application.Interface;
using System.Runtime.CompilerServices;

namespace JobOfferAnalyzer.Application.Services
{
    public class CalcInssServices : ICalcInssServices
    {
        private const decimal Ceiling = 7786.02m;

        public decimal ComputeDeductionInss(decimal salary)
        {
            decimal salaryToConsider = salary > Ceiling ? Ceiling : salary;

            decimal deduction = 0.0m;

            if (salaryToConsider <= 1412.00m)
            {
                deduction += salaryToConsider * 0.075m;
            }
            else if (salaryToConsider <= 2666.68m)
            {
                deduction += (1412.00m * 0.075m);
                deduction += (salaryToConsider - 1412.00m) * 0.09m;
            }
            else if (salaryToConsider <= 4000.03m)
            {
                deduction += (1412.00m * 0.075m);
                deduction += (2666.68m - 1412.00m) * 0.09m;
                deduction += (salaryToConsider - 2666.68m) * 0.12m;
            }
            else
            {
                deduction += (1412.00m * 0.075m);
                deduction += (2666.68m - 1412.00m) * 0.09m;
                deduction += (4000.03m - 2666.68m) * 0.12m;
                deduction += (salaryToConsider - 4000.03m) * 0.14m;
            }

            return Math.Round(deduction, 2);
        }
    }
}
