using AutoMapper;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Application.UseCases.Expenses.GetById;

public class GetByIdExpenseUseCase: IGetByIdExpenseUseCase
{
    private readonly IExpensesRepository _repository;
    private readonly IMapper _mapper;
    public GetByIdExpenseUseCase(IExpensesRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ResponseExpensesJson> Execute(Guid id)
    {
        var result = await _repository.GetById(id);

        return _mapper.Map<ResponseExpensesJson>(result);
    }
}
