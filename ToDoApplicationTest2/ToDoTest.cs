using ToDoApplication.Models;
using Xunit;

namespace ToDoApplicationTest2
{
    public class ToDoTest
    { 
       [Fact]
        public void TodoClassSetValues()
        {
            //Arrnge
            int todoId = 1;
            string description = "Hello";
           //Act
            Todo todo = new Todo(1,"Hello");
            //Accert
            Assert.Equal(todoId,todo.todoId);
            Assert.Equal(description, todo.description);
        }
    }
}
