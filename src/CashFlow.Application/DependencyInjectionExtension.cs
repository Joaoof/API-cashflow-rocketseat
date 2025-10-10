﻿using CashFlow.Application.AutoMapper;
using CashFlow.Application.UseCases.Expenses.GetAll;
using CashFlow.Application.UseCases.Expenses.Register;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlow.Application;

public static class DependencyInjectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddAutoMapper(services);
        AddUseCases(services);
    }

    private static void AddAutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(cfg => { }, typeof(AutoMapping).Assembly);
    }

    private static void AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<IRegisterExpenseUseCase, RegisterExpenseUseCase>();          
        services.AddScoped<IGetAllExpenseUseCase, GetAllExpenseUseCase>();
    }
}
