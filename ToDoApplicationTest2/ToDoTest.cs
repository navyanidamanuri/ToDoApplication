using ToDoApplication.Data;
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
            bool done = true;
            Person assignee = new Person(PersonSequencer.nextPersonId(), "Vanshi","Madhu");
           //Act
            Todo todo = new Todo(1,"Hello", assignee, true);
            //Accert
            Assert.Equal(todoId,todo.todoId);
            Assert.Equal(description, todo.description);
            Assert.Equal(assignee, todo.assignee);
            Assert.Equal(done, todo.done);
        }
    }
}
