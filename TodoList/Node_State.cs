using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    internal class Node_State
    {
        List_Event state = new List_Event();
        Node_State next;

        internal Node_State Next { get => next; set => next = value; }
        internal List_Event State { get => state; set => state = value; }
    }
}
