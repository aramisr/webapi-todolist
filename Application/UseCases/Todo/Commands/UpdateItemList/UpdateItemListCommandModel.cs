namespace Application.UseCases.Todo.Commands.UpdateItemList;
public class UpdateItemListCommandModel
{
    public Guid Id { get; set; }
    public string Status { get; set; } = "Finalizada";
    public DateTime DateEnd { get; set; }
}
