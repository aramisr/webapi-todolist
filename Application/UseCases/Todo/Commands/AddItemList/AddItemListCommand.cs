using Application.Common.Interfaces;
using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Todo.Commands.AddItemList;

public class AddItemListCommand : AddItemListCommandModel, IRequest<Result<AddItemListCommandDto>>
{
    public class AddItemListCommandHandler(
        IRepository<TodoList> todoListRepository) : UseCaseHandler, IRequestHandler<AddItemListCommand, Result<AddItemListCommandDto>>
    {
        public async Task<Result<AddItemListCommandDto>> Handle(AddItemListCommand request, CancellationToken cancellationToken)
        {
            var itemTodo = new TodoList
            {
                Id = Guid.NewGuid(),
                TaskName = request.TaskName,
                Status = "En progreso",
                DateCreation = DateTime.Now
            };

            await todoListRepository.AddAsync(itemTodo);

            var resultData = new AddItemListCommandDto { Success = true };

            return Succeded(resultData);
        }
    }
}
