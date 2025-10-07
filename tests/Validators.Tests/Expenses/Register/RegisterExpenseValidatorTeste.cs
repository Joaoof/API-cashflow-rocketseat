using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Request;

namespace Validators.Tests.Expenses.Register;

public class RegisterExpenseValidatorTeste
{
    [Fact]
    public void Success()
    {
        var validator = new RegisterExpenseValidator();

        var request = new RequestRegisterExpenseJson
        {
            Amount = 100,
            Date = DateTime.Now.AddDays(-1),
            Description = "description",
            Title = "title",
            PaymentType = CashFlow.Communication.Enums.PaymentType.CreditCard
        };

        var result = validator.Validate(request);

        Assert.True(result.IsValid);

    }
}
