using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApplication.Data
{
     public class PersonSequencer
    {
        public static int personId=0;
        public static int nextPersonId()
        {
            personId++;
            return personId;
        }
        public static void Reset()
        {
            personId = 0;
        }
    }
}
