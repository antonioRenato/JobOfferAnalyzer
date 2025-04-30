using JobOfferAnalyzer.Domain.Entities;

namespace JobOfferAnalyzer.Application.Interface.Strategy
{
    public class CltSalaryCalculationStrategy : ISalaryCalculationStrategy
    {
        private readonly ICalcFgtsServices _calcFgtsServices;
        private readonly ICalcInssServices _calcInssServices;
        private readonly ICalcIrServices _calcIrServices;

        public CltSalaryCalculationStrategy(ICalcFgtsServices calcFgtsServices, ICalcInssServices calcInssServices, ICalcIrServices calcIrServices)
        {
            _calcFgtsServices = calcFgtsServices;
            _calcInssServices = calcInssServices;
            _calcIrServices = calcIrServices;
        }

        public SalaryDeductionResult Calculate(decimal grossSalary)
        {
            // INSS Deduction
            var inssDeduction = _calcInssServices.ComputeDeductionInss(grossSalary);

            // IR Deduction
            var baseIr = _calcIrServices.ComputeBaseIr(grossSalary, inssDeduction);
            var irDeduction = _calcIrServices.ComputeDeductionIR(baseIr);

            // FGTS Deduction
            var fgtsDeduction = _calcFgtsServices.ComputeFgts(grossSalary);

            var netSalary = grossSalary - inssDeduction - irDeduction;

            return new SalaryDeductionResult
            {
                GrossSalary = grossSalary,
                InssDeduction = inssDeduction,
                IrDeduction = irDeduction,
                FgtsDeduction = fgtsDeduction,
                NetSalary = netSalary
            };
        }
    }
}
