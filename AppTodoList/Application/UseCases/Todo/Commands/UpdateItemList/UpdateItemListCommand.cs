using Application.Common.Interfaces;
using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Todo.Commands.UpdateItemList;
public class UpdateItemListCommand : UpdateItemListCommandModel, IRequest<Result<UpdateItemListCommandDto>>
{
    public class UpdateItemListCommandHandler(
        IRepository<TodoList> todoListRepository) : UseCaseHandler, IRequestHandler<UpdateItemListCommand, Result<UpdateItemListCommandDto>>
    {
        public async Task<Result<UpdateItemListCommandDto>> Handle(UpdateItemListCommand request, CancellationToken cancellationToken)
        {
            var transaction =
                    await todoListRepository.GetByIdAsync(request.Id)
                    ?? throw (new ArgumentException("The transaction id does not exist"));

            transaction.Status = request.Status;
            if (request.Status.Contains("Finalizada"))
            {
                transaction.DateEnd = DateTime.UtcNow;
            }

            await todoListRepository.UpdateAsync(transaction);

            var resultData = new UpdateItemListCommandDto { Success = true };

            return this.Succeded(resultData);
        }
    }
}
