using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApplication.Data
{
    public class TodoSequencer
    {
        public static int todoId;
        public static int nextToDoId(int todoId)
        {
            todoId++;
            return todoId;
        }
        public static void Reset()
        {
            todoId = 0;
        }

        public object nexttodoId(int todoId)
        {
            throw new NotImplementedException();
        }
    }
}
