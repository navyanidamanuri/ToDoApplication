using System;

namespace ToDoApplication.Models
{
   public class Person
    {
        public  int personId;
        public string firstName;
        public string lastName;

        public Person(int personId, string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))

                throw new ArgumentNullException("firstName,lastName", "firstName or lastName can not be null or empty");

            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
