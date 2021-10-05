using ToDoApplication.Data;
using ToDoApplication.Models;
using Xunit;

namespace ToDoApplicationTest6
{
    public class TodoItemsTest
    {
        [Fact]
        public void UpdateTodo()
        {
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("deepu", "k");
            todo.UpdateTodoArray("vanshi", "K");
            Assert.Equal("deepuk",Todo.TodoArray[0].firstName + Todo.TodoArray[0].lastName);
            Assert.Equal("vanshiK", Todo.TodoArray[1].firstName + Todo.TodoArray[1].lastName);
        }

        [Fact]
        public void FindAllTodo()
        {
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("deepu", "k");
            todo.UpdateTodoArray("vanshi", "K");
            Todo[] TodoArray = new Todo[] { };
            TodoArray = todo.FindAll();
            Assert.Equal(2, TodoArray.Length);
        }

        [Fact]
        public void FindTodoById()
        {
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("deepu", "k");
            todo.UpdateTodoArray("vanshi", "K");
            Todo todo = todo.FindById(2);
            Assert.Equal(2, todo.todoId);
        }

        [Fact]
        public void ClearTodo()
        {
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("Navya", "Lakshmi");
            todo.UpdateTodoArray("Madhu", "K");
            todo.Clear();
            Assert.Equal(0, Todo.TodoArray.Length);
        }
    }
}
