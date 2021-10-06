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
            todo.UpdateTodoArray("Son", null, false);
            todo.UpdateTodoArray("Daughter", new Person(PersonSequencer.nextPersonId(), "Vanshi", "Madhu"), true);
            Assert.Equal("Son", TodoItems.TodoArray[0].description);
            Assert.Equal("Daughter", TodoItems.TodoArray[1].description);
            Assert.Equal("VanshiMadhu", TodoItems.TodoArray[1].assignee.firstName + TodoItems.TodoArray[1].assignee.lastName);
        }

        [Fact]
        public void FindAllTodo()
        {
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("Son", null, false);
            todo.UpdateTodoArray("Daughter", new Person(PersonSequencer.nextPersonId(), "Vanshi", "Madhu"), true);
            Assert.Equal(2, TodoItems.TodoArray.Length);
        }

        [Fact]
        public void FindTodoById()
        {
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("Son", null, false);
            todo.UpdateTodoArray("Daughter", new Person(PersonSequencer.nextPersonId(), "Vanshi", "Madhu"), true);
            Todo todoItem = todo.FindById(2);
            Assert.Equal("VanshiMadhu", todoItem.assignee.firstName + todoItem.assignee.lastName);
        }

        [Fact]
        public void FindTodoByAssignee()
        {
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("Son", null, false);
            todo.UpdateTodoArray("Daughter", new Person(PersonSequencer.nextPersonId(), "Vanshi", "Madhu"), true);
            Todo[] todoItem = new Todo[] { };
            todoItem = todo.FindByAssignee(2);
            Assert.Equal("VanshiMadhu", todoItem[0].assignee.firstName + todoItem[0].assignee.lastName);
        }

        [Fact]
        public void FindTodoByAssignedPerson()
        {
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("Son", null, false);
            todo.UpdateTodoArray("Daughter", new Person(PersonSequencer.nextPersonId(), "Vanshi", "Madhu"), true);
            Todo[] todoItem = new Todo[] { };
            todoItem = todo.FindByAssignee(new Person(1, "Vanshi", "Madhu"));
            Assert.Equal("VanshiMadhu", todoItem[0].assignee.firstName + todoItem[0].assignee.lastName);
        }
        [Fact]
        public void FindTodoByUnAssignedPerson()
        {
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("Son", null, false);
            todo.UpdateTodoArray("Daughter", new Person(PersonSequencer.nextPersonId(), "Vanshi", "Madhu"), true);
            Todo[] todoItem = new Todo[] { };
            todoItem = todo.FindUnassignedTodoItems();
            Assert.Equal("null", todoItem[0].assignee.);
        }
        public void RemoveOneObjectfromTodoArray()
        {
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("Son", null, false);
            todo.UpdateTodoArray("Daughter", new Person(PersonSequencer.nextPersonId(), "Vanshi", "Madhu"), true);
            Todo[] todoItem = new Todo[] { };
            todoItem = todo.RemoveObjectFromTodoArray(int 1);
            Assert.Equal("null", todoItem[0].assignee.);
        }

        [Fact]
        public void ClearTodo()
        {
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("Son", null, false);
            todo.UpdateTodoArray("Daughter", new Person(PersonSequencer.nextPersonId(), "Vanshi", "Madhu"), true);
            todo.Clear();
            Assert.Equal(0, TodoItems.TodoArray.Length);
        }


    }
}