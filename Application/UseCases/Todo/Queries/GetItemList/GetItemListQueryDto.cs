namespace Application.UseCases.Todo.Queries.GetItemList;
public class GetItemListQueryDto
{
    public int Id { get; set; }
    public string TaskName { get; set; }
    public string Status { get; set; }
    public DateTime DateCreation { get; set; }
    public DateTime DateEnd { get; set; }
}
