using JobOfferAnalyzer.Application.Interface;

namespace JobOfferAnalyzer.Application.Services
{
    public class CalcIrServices : ICalcIrServices
    {
        private const decimal FIRST_BRACKET_LIMIT = 2259.20m;
        private const decimal SECOND_BRACKET_LIMIT = 3000.00m;
        private const decimal THIRD_BRACKET_LIMIT = 4500.00m;
        private const decimal FOURTH_BRACKET_LIMIT = 5500.00m;

        private const decimal FIRST_BRACKET_DEDUCTION = 169.44m;
        private const decimal SECOND_BRACKET_DEDUCTION = 381.44m;
        private const decimal THIRD_BRACKET_DEDUCTION = 662.69m;
        private const decimal FOURTH_BRACKET_DEDUCTION = 896.00m;

        public decimal ComputeBaseIr(decimal salary, decimal baseInss)
        {
            return salary - baseInss;
        }

        public decimal ComputeDeductionIR(decimal baseIr)
        {
            if (baseIr <= FIRST_BRACKET_LIMIT)
                return 0m;
            else if (baseIr <= SECOND_BRACKET_LIMIT)
                return Math.Round((baseIr * 0.075m) - FIRST_BRACKET_DEDUCTION, 2);
            else if (baseIr <= THIRD_BRACKET_LIMIT)
                return Math.Round((baseIr * 0.15m) - SECOND_BRACKET_DEDUCTION, 2);
            else if (baseIr <= FOURTH_BRACKET_LIMIT)
                return Math.Round((baseIr * 0.225m) - THIRD_BRACKET_DEDUCTION, 2);
            else
                return Math.Round((baseIr * 0.275m) - FOURTH_BRACKET_DEDUCTION, 2);
        }
    }
}
