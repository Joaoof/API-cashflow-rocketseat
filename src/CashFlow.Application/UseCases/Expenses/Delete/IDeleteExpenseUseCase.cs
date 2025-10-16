namespace CashFlow.Application.UseCases.Expenses.Delete;

public interface IDeleteExpenseUseCase
{
    Task<bool> Execute(Guid id);
}
