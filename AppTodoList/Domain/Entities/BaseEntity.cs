using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;
public class BaseEntity
{
    public Guid Id { get; set; }
}
