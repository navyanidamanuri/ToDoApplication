using ToDoApplication.Data;
using Xunit;

namespace ToDoApplicationTest4
{
    public class TodoSequencerTest
    {
        [Fact]
        public void TodoSequencerSetId()
        {
            //Arrnge
            int todoId = 1;

            //Act
            TodoSequencer todo = new TodoSequencer();
            object result = todo.nexttodoId(todoId);

            //Accert
            Assert.Equal(2, result);
        }

        [Fact]
        public void TodoSequencerReSetId()
        {
            //Arrnge
            int todoId = 1;

            //Act
            TodoSequencer todo1 = new TodoSequencer();
            object result = todo1.Reset();

            //Accert
            Assert.Equal(0, result);

        }
    }
}
