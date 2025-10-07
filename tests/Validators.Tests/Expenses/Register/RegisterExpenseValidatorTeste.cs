using CashFlow.Application.UseCases.Expenses.Register;
using CommonTestUtilities.Request;

namespace Validators.Tests.Expenses.Register;

public class RegisterExpenseValidatorTeste
{
    [Fact]
    public void Success()
    {
        var validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpensesJsonBuilder.Build();

        var result = validator.Validate(request);

        Assert.True(result.IsValid);

    }
}
