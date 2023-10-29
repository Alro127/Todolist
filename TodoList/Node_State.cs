using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class Node_State
    {
        List_Event state = new List_Event();
        Node_State next;

        public Node_State()
        {

        }
        public Node_State(List_Event new_list)
        {
            State = new_list;
        }
        public Node_State Next { get => next; set => next = value; }
        public List_Event State { get => state; set => state = value; }
    }
}
