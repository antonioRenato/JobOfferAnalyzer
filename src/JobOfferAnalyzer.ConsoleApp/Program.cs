using JobOfferAnalyzer.Application.Interface.UseCase;
using JobOfferAnalyzer.ConsoleApp.IoC;
using Microsoft.Extensions.DependencyInjection;
using JobOfferAnalyzer.Domain.Enums;

public class Program
{
    public static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddApplicationServices();

        var provider = services.BuildServiceProvider();

        var salaryUseCase = provider.GetRequiredService<ICalculateSalaryUseCase>();

        var result = salaryUseCase.Execute(6000, ContractType.CLT);
        Console.WriteLine($"Salário líquido: {result.NetSalary:C}");
    }
}