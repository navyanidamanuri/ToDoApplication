using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApplication.Models
{
     public class Todo
    {
        public readonly int todoId;
        public string description;
        private bool done;
        private Person assignee;
        public Todo(int todoId, string description)
        {
            this.todoId = todoId;
            this.description = description;
        }

    }
}
