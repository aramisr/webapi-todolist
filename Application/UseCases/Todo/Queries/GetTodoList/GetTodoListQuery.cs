using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;
using Application.Common.Interfaces;
using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using Domain.Entities;
using MediatR;
namespace Application.UseCases.Todo.Queries.GetTodoList;

public class GetTodoListQuery : IRequest<Result<GetTodoListQueryDto>>
{
    public class GetTodoListHandler(
        IConfiguration configuration,
        IRepository<TodoList> todoListRepository) : UseCaseHandler, IRequestHandler<GetTodoListQuery, Result<GetTodoListQueryDto>>
    {
        public async Task<Result<GetTodoListQueryDto>> Handle(GetTodoListQuery request, CancellationToken cancellationToken)
        {
            var listTodo = await todoListRepository.GetAllAsync();

            var transactionsDto = listTodo
                    .Select(x => new GetTodoListQueryValueDto()
                    {
                        Id = x.Id,
                        TaskName = x.TaskName,
                        Status = x.Status,
                        DateCreation = x.DateCreation,
                        DateEnd = x.DateEnd
                    });

            var resultData = new GetTodoListQueryDto()
            {
                Transactions = transactionsDto
            };

            return this.Succeded(resultData);
        }
    }
}
