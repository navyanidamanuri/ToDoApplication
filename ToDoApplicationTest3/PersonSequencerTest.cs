using ToDoApplication.Data;
using Xunit;

namespace ToDoApplicationTest3
{
    public class PersonSequencerTest
    {
        [Fact]
        public void PersonSequencerSetId()
        {
            //Arrnge
            int personId = 1;

           //Act
            PersonSequencer per = new PersonSequencer();
             object result = per.nextPersonId(personId);

            //Accert
            Assert.Equal(2, result);
         }

        [Fact]
        public void PersonSequencerReSetId()
        {
            //Arrnge
            int personId = 1;

            //Act
            PersonSequencer per1 = new PersonSequencer();
            var result = per1.Reset(personId);

            //Accert
            Assert.Equal(0, result);

        }
    } 
}
