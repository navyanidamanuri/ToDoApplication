using System;
using System.Collections.Generic;
using System.Text;
using ToDoApplication.Models;

namespace ToDoApplication.Data
{
    public class People
    {
        public static Person[] PersonArray = new Person[0];

        public int Size()
        {
            return PersonArray.Length;
        }
        public Person[] FindAll()
        {
            return PersonArray;
        }

        public Person FindById(int personId)
        {
            foreach (var person in PersonArray)
            {
                if (person.personId == personId)
                {
                    return person;
                }
            }
            return null;
        }

        public Person UpdatePersonArray(string firstName, string lastName)
        {
            var personSequencer = new PersonSequencer();
            var nextPersonId = PersonSequencer.nextPersonId();
            var person = new Person(nextPersonId, firstName, lastName);
            Array.Resize(ref PersonArray, Size() + 1);
            PersonArray[Size() - 1] = person;
            return person;
        }
        public void Clear()
        {
            PersonArray = new Person[0];
        }
        public void RemoveObjectFromPersonArray(int index)
        {
            for (int i = 0; i < PersonArray.Length; i++)
            {
                if (i == index)
                {
                    for (int j = i + 1; j < PersonArray.Length; i++, j++)
                    {
                        PersonArray[i] = PersonArray[j];
                    }
                    Array.Resize(ref PersonArray, PersonArray.Length - 1);
                    break;
                }
            }
        }


    }
}




