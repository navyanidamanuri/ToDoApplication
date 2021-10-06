using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApplication.Models
{
     public class Todo
    {
        public readonly int todoId;
        public string description;
        public bool done;
        public Person assignee;
        public Todo(int todoId, string description, Person assign,bool isDone)
        {
            this.todoId = todoId;
            this.description = description;
            this.assignee = assign;
            this.done = isDone;
        }

    }
}
