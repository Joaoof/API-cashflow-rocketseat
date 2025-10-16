using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.GetById;

public interface IGetByIdExpenseUseCase
{
    Task<ResponseExpensesJson> Execute(Guid id);
}
