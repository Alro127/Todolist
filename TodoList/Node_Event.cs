using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    internal class Node_Event
    {
        string _event;
        DateTime _deadline;
        Node_Event next;

        public Node_Event() 
        {
        }

        public string Event { get => _event; set => _event = value; }
        public DateTime Deadline { get => _deadline; set => _deadline = value; }
        internal Node_Event Next { get => next; set => next = value; }
    }
}
