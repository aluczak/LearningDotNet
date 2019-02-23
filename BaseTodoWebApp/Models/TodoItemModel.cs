using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseTodoWebApp.Models
{
    public class TodoItemModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool Completed { get; set; }

        public DateTime? DueDate { get; set; }
    }
}
