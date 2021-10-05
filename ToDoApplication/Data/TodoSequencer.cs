using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApplication.Data
{
    public class TodoSequencer
    {
        public static int todoId = 0;
        public static int nextToDoId()
        {
            todoId++;
            return todoId;
        }
        public static void Reset()
        {
            todoId = 0;
        }
      }
}
