﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApplication.Data
{
     public class PersonSequencer
    {
        public static int personId;
        public static int nextPersonId(int personId)
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
