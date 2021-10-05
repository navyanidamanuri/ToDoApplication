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
            People people = new People();
            people.UpdatePersonArray("Navya", "Lakshmi");
            people.UpdatePersonArray("Madhu", "K");
            Assert.Equal("NavyaLakshmi", People.PersonArray[0].firstName + People.PersonArray[0].lastName);
            Assert.Equal("MadhuK", People.PersonArray[1].firstName + People.PersonArray[1].lastName);
        }

        [Fact]
        public void FindAllPeople()
        {
            People people = new People();
            people.UpdatePersonArray("Navya", "Lakshmi");
            people.UpdatePersonArray("Madhu", "K");
            Person[] personArray = new Person[] { };
            personArray = people.FindAll();
            Assert.Equal(2, personArray.Length);
        }

        [Fact]
        public void FindPeopleById()
        {
            People people = new People();
            people.UpdatePersonArray("Navya", "Lakshmi");
            people.UpdatePersonArray("Madhu", "K");
            Person person = people.FindById(2);
            Assert.Equal(2, person.personId);
        }

        [Fact]
        public void ClearPeople()
        {
            People people = new People();
            people.UpdatePersonArray("Navya", "Lakshmi");
            people.UpdatePersonArray("Madhu", "K");
            people.Clear();
            Assert.Equal(0, People.PersonArray.Length);
        }
    }
}
