namespace Application.UseCases.Todo.Queries.GetTodoList;
public class GetTodoListQueryDto
{
    public IEnumerable<GetTodoListQueryValueDto>? Transactions { get; set; }
}
