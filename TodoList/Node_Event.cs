using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class Node_Event
    {
        string _event;
        DateTime _deadline;
        Node_Event next;

        public Node_Event() 
        {
        }
        public Node_Event(string event_value, DateTime deadline_value)
        {
            Event = event_value;
            Deadline = deadline_value;
        }

        public string Event { get => _event; set => _event = value; }
        public DateTime Deadline { get => _deadline; set => _deadline = value; }
        public Node_Event Next { get => next; set => next = value; }

        public override string ToString()
        {
            return Event + " " +Deadline.ToLongTimeString();
        }
    }
}
