using JobOfferAnalyzer.Application.Interface.UseCase;
using JobOfferAnalyzer.ConsoleApp.IoC;
using Microsoft.Extensions.DependencyInjection;
using JobOfferAnalyzer.Domain.Entities;

public class Program
{
    public static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddApplicationServices();

        var provider = services.BuildServiceProvider();

        // Criação manual do input
        //var input = new SalaryCalculationInput
       // {
       //     GrossSalary = 8000m,
       //     ContractType = ContractType.PJ
       // };

        //var salaryUseCase = provider.GetRequiredService<ICalculateSalaryUseCase>();

        //var result = salaryUseCase.Execute(input);
        //Console.WriteLine($"Salário líquido: {result.NetSalary:C}");
    }
}