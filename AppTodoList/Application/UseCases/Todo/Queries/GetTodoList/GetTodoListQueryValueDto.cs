namespace Application.UseCases.Todo.Queries.GetTodoList;
public class GetTodoListQueryValueDto
{
    public Guid Id { get; set; }
    public string TaskName { get; set; }
    public string Status { get; set; }
    public DateTime DateCreation { get; set; }
    public DateTime DateEnd { get; set; }
}
