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

        public Todo UpdateTodoArray(string description, Person assignee, bool isDone)
        {
            var nextTodoId = TodoSequencer.nextToDoId();
            var todo = new Todo(nextTodoId, description, assignee, isDone);
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
            Todo[] todoDoneArray = new Todo[] { };
            int count = 0;
            foreach (var t in TodoArray)
            {
                if (t.done == doneStatus)
                {
                    todoDoneArray[count] = t;
                    count++;
                }
            }
            return todoDoneArray;
        }
        public Todo[] FindByAssignee(int todoId)
        {
            Todo[] todoPersonArray = new Todo[] { };
            int count = 0;
            foreach (var t in TodoArray)
            {
                if (t.todoId == todoId)
                {
                    Array.Resize(ref todoPersonArray, todoPersonArray.Length + 1);
                    todoPersonArray[count] = t;
                    count++;
                }
            }
            return todoPersonArray;
        }
        public Todo[] FindByAssignee(Person assignee)
        {
            Todo[] todoPersonArray = new Todo[] { };
            int count = 0;
            foreach (var t in TodoArray)
            {
                if (t?.assignee?.personId == assignee.personId && t?.assignee?.firstName == assignee.firstName && t?.assignee?.lastName == assignee.lastName)
                {
                    Array.Resize(ref todoPersonArray, todoPersonArray.Length + 1);
                    todoPersonArray[count] = t;
                    count++;
                }
            }
            return todoPersonArray;
        }
        public Todo[] FindUnassignedTodoItems()
        {
            Todo[] todoUnassignedArray = new Todo[] { };
            int count = 0;
            foreach (var t in TodoArray)
            {
                if (t.assignee == null)
                {
                    Array.Resize(ref todoUnassignedArray, todoUnassignedArray.Length + 1);
                    todoUnassignedArray[count] = t;
                    count++;
                }
            }
            return todoUnassignedArray;
        }

        public void RemoveObjectFromTodoArray(int index)
        {
            for (int i = 0; i < TodoArray.Length; i++)
            {
                if (i == index)
                {
                    for (int j = i + 1; j < TodoArray.Length; i++, j++)
                    {
                        TodoArray[i] = TodoArray[j];
                    }
                    Array.Resize(ref TodoArray, TodoArray.Length - 1);
                    break;
                }
            }
        }

    }
 }