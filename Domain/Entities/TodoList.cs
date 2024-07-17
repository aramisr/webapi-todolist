using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TodoList : BaseEntity
    {
        public string TaskName { get; set; }
        public string Status { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
