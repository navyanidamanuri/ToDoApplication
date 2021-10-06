using ToDoApplication.Data;
using ToDoApplication.Models;
using Xunit;

namespace ToDoApplicationTest5
   {
    public class PeopleTest
    {
        [Fact]
        public void UpdatePeople()
        {
            //Arrange
            People people = new People();
            people.UpdatePersonArray("Navya", "Lakshmi");
            people.UpdatePersonArray("Madhu", "K");
            //Assert
            Assert.Equal("NavyaLakshmi", People.PersonArray[0].firstName + People.PersonArray[0].lastName);
            Assert.Equal("MadhuK", People.PersonArray[1].firstName + People.PersonArray[1].lastName);
        }

        [Fact]
        public void FindAllPeople()
        {
            //Arrange
            People people = new People();
            people.UpdatePersonArray("Navya", "Lakshmi");
            people.UpdatePersonArray("Madhu", "K");
            //Act
            Person[] personArray = new Person[] { };
            personArray = people.FindAll();
            // Assert
            Assert.Equal(2, personArray.Length);
        }

        [Fact]
        public void FindPeopleById()
        {
            //Arrange
            People people = new People();
            people.UpdatePersonArray("Navya", "Lakshmi");
            people.UpdatePersonArray("Madhu", "K");
            //Act
            Person person = people.FindById(2);
            // Assert
            Assert.Equal(2, person.personId);
        }
        [Fact]
        public void RemoveOneObjectFromTodoArray()
        {
            //Arrange
            People people = new People();
            people.UpdatePersonArray("Navya", "Lakshmi");
            people.UpdatePersonArray("Madhu", "K");
            //Act
            people.RemoveObjectFromPersonArray(1);
            // Assert
            Assert.Equal(1, People.PersonArray.Length);
        }

        [Fact]
        public void ClearPeople()
        {
            //Arrange
            People people = new People();
            people.UpdatePersonArray("Navya", "Lakshmi");
            people.UpdatePersonArray("Madhu", "K");
            //Act
            people.Clear();
            // Assert
            Assert.Equal(0, People.PersonArray.Length);
        }
    }
}
