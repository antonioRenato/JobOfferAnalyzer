using FluentValidation;
using JobOfferAnalyzer.Application.Factory;
using JobOfferAnalyzer.Application.Interface;
using JobOfferAnalyzer.Application.Interface.Factory;
using JobOfferAnalyzer.Application.Interface.Strategy;
using JobOfferAnalyzer.Application.Interface.UseCase;
using JobOfferAnalyzer.Application.Services;
using JobOfferAnalyzer.Application.UseCases;
using JobOfferAnalyzer.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace JobOfferAnalyzer.ConsoleApp.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Services
            services.AddScoped<ICalcInssServices, CalcInssServices>();
            services.AddScoped<ICalcIrServices, CalcIrServices>();
            services.AddScoped<ICalcFgtsServices, CalcFgtsServices>();

            // Strategies
            services.AddScoped<CltSalaryCalculationStrategy>();
            services.AddScoped<PjSalaryCalculationStrategy>();

            // Factory
            services.AddScoped<ISalaryStrategyFactory, SalaryStrategyFactory>();

            // UseCases
            services.AddScoped<ICalculateSalaryUseCase, CalculateSalaryUseCase>();
            services.AddScoped<IValidator<SalaryCalculationInput>, SalaryCalculationInputValidator>();

            return services;
        }
    }
}
