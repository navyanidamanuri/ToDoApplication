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
            //Arrange
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("Son", null, false);
            todo.UpdateTodoArray("Daughter", new Person(PersonSequencer.nextPersonId(), "Vanshi", "Madhu"), true);
            //Assert
            Assert.Equal("Son", TodoItems.TodoArray[0].description);
            Assert.Equal("Daughter", TodoItems.TodoArray[1].description);
            Assert.Equal("VanshiMadhu", TodoItems.TodoArray[1].assignee.firstName + TodoItems.TodoArray[1].assignee.lastName);
        }

        [Fact]
        public void FindAllTodo()
        {
            //Arrange
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("Son", null, false);
            todo.UpdateTodoArray("Daughter", new Person(PersonSequencer.nextPersonId(), "Vanshi", "Madhu"), true);
            //Assert
            Assert.Equal(2, TodoItems.TodoArray.Length);
        }

        [Fact]
        public void FindTodoById()
        {
            //Arrange
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("Son", null, false);
            todo.UpdateTodoArray("Daughter", new Person(PersonSequencer.nextPersonId(), "Vanshi", "Madhu"), true);
            //Act
            Todo todoItem = todo.FindById(2);
            //Assert
            Assert.Equal("VanshiMadhu", todoItem.assignee.firstName + todoItem.assignee.lastName);
        }

        [Fact]
        public void FindTodoByAssignee()
        {
            //Arrange
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("Son", null, false);
            todo.UpdateTodoArray("Daughter", new Person(PersonSequencer.nextPersonId(), "Vanshi", "Madhu"), true);
            //Act
            var todoItem = todo.FindByAssignee(2);
            //Assert
            Assert.Equal("VanshiMadhu", todoItem[0].assignee.firstName + todoItem[0].assignee.lastName);
        }

        [Fact]
        public void FindTodoByAssignedPerson()
        {
            //Arrange
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("Son", null, false);
            todo.UpdateTodoArray("Daughter", new Person(PersonSequencer.nextPersonId(), "Vanshi", "Madhu"), true);
            //Act
            var todoItem = todo.FindByAssignee(new Person(1, "Vanshi", "Madhu"));
            //Assert
            Assert.Equal("VanshiMadhu", todoItem[0].assignee.firstName + todoItem[0].assignee.lastName);
        }
        [Fact]
        public void FindTodoByUnAssignedPerson()
        {
            //Arrange
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("Son", null, false);
            todo.UpdateTodoArray("Daughter", new Person(PersonSequencer.nextPersonId(), "Vanshi", "Madhu"), true);
            //Act
            Todo[] todoItem = new Todo[] { };
            todoItem = todo.FindUnassignedTodoItems();
            //Assert
            Assert.Equal(null, todoItem[0].assignee);
        }
        [Fact]
        public void RemoveOneObjectfromTodoArray()
        {
            //Arrange
            TodoItems todo = new TodoItems();
            todo.UpdateTodoArray("Son", null, false);
            todo.UpdateTodoArray("Daughter", new Person(PersonSequencer.nextPersonId(), "Vanshi", "Madhu"), true);
            //Act
            todo.RemoveObjectFromTodoArray(1);
            //Assert
            Assert.Equal(1, TodoItems.TodoArray.Length);
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