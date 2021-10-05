using System;
using System.Collections.Generic;
using System.Text;
using ToDoApplication.Models;

namespace ToDoApplication.Data
{
    public class TodoItems
    {
        public static Todo[] TodoArray = new Todo[0];

        public int Size()
        {
            return TodoArray.Length;
        }
        public Todo[] FindAll()
        {
            return TodoArray;
        }

        public Todo FindById(int todoId)
        {
            foreach (var Todo in TodoArray)
            {
                if (Todo.todoId == todoId)
                {
                    return Todo;
                }
            }
            return null;
        }

        public Todo UpdateTodoArray(string firstName, string lastName)
        {
            var TodoSequencer = new TodoSequencer();
            var nextTodoId = TodoSequencer.nextToDoId();
            var todo = new Todo(nextTodoId, firstName, lastName);
            Array.Resize(ref TodoArray, Size() + 1);
            TodoArray[Size() - 1] = todo;
            return todo;
        }
        public void Clear()
        {
            TodoArray = new Todo[0];
        }
        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            foreach (var Todo in TodoArray)
            {
                if (Todo.doneStatus == doneStatus)
                {
                    return true;
                }
            }
            return false;

        }
        public Todo[] FindByAssignee(int personId)
        {
           
        }
        public Todo[] FindByAssignee(Person assignee)
        {

        }
        public Todo[] FindUnassignedTodoItems()
        {

        }


    }

}
