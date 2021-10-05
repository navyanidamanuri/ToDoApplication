using ToDoApplication.Data;
using Xunit;

namespace ToDoApplicationTest3
{
    public class PersonSequencerTest
    {
        [Fact]
        public void PersonSequencerSetId()
        {
            //Act
            PersonSequencer.nextPersonId();
            PersonSequencer.nextPersonId();
            //Assert
            Assert.Equal(2, PersonSequencer.personId);
        }

        [Fact]
        public void PersonSequencerReSetId()
        {
            //Act
            PersonSequencer.nextPersonId();
            PersonSequencer.nextPersonId();
            PersonSequencer.nextPersonId();
            PersonSequencer.Reset();
            //Assert
            Assert.Equal(0, PersonSequencer.personId);
        }
    }
}