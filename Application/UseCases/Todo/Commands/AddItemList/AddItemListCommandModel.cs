using System.ComponentModel.DataAnnotations;

namespace Application.UseCases.Todo.Commands.AddItemList;
public class AddItemListCommandModel
{
    [Required(ErrorMessage = "TaskName is required.")]
    public string TaskName { get; set; }
}
