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
            Person assignee = navya;
           //Act
            Todo todo = new Todo(1,"Hello",'navya',true);
            //Accert
            Assert.Equal(todoId,todo.todoId);
            Assert.Equal(description, todo.assignee);
        }
    }
}
