﻿using JobOfferAnalyzer.Application.Interface;

namespace JobOfferAnalyzer.Application.Services
{
    public class CalcFgtsServices : ICalcFgtsServices
    {
        public decimal ComputeFgts(decimal salary)
        {
            return salary * 0.08m;
        }
    }
}
