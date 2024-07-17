using Application.Common.Interfaces;
using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Todo.Queries.GetItemList;
public class GetItemListQuery : GetItemListQueryModel, IRequest<Result<GetItemListQueryDto>>
{
    public class GetItemListQueryHandler(
        IRepository<TodoList> todoListRepository) : UseCaseHandler, IRequestHandler<GetItemListQuery, Result<GetItemListQueryDto>>
    {
        [Obsolete]
        public async Task<Result<GetItemListQueryDto>> Handle(GetItemListQuery request, CancellationToken cancellationToken)
        {
            var transaction = await todoListRepository.GetByIdAsync(request.Id) ?? throw (new ArgumentException("The transaction id does not exist"));

            var resultData = new GetItemListQueryDto()
            {
                TaskName = transaction.TaskName,
                Status = transaction.Status,
                DateCreation = transaction.DateCreation,
                DateEnd = transaction.DateEnd
            };

            return this.Succeded(resultData);
        }
    }
}
