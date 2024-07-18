using Application.Common.Interfaces;
using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Todo.Commands.RemoveItemList;
public class RemoveItemListCommand : RemoveItemListCommandModel, IRequest<Result<RemoveItemListCommandDto>>
{
    public class RemoveItemListCommandHandler(
        IRepository<TodoList> todoListRepository) : UseCaseHandler, IRequestHandler<RemoveItemListCommand, Result<RemoveItemListCommandDto>>
    {
        public async Task<Result<RemoveItemListCommandDto>> Handle(RemoveItemListCommand request, CancellationToken cancellationToken)
        {
            var transaction =
                    await todoListRepository.GetByIdAsync(request.Id)
                    ?? throw (new ArgumentException("The transaction id does not exist"));

            await todoListRepository.DeleteAsync(transaction);

            var resultData = new RemoveItemListCommandDto { Success = true };

            return this.Succeded(resultData);
        }
    }
}
