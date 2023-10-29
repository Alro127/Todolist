using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class List_Event
    {
        Node_Event head = new Node_Event();
        Node_Event tail = new Node_Event();

        public Node_Event Head { get => head; set => head = value; }
        public Node_Event Tail { get => tail; set => tail = value; }

        public List_Event()
        {
            Head = null;
            Tail = null;
        }
        public void Add(Node_Event p)
        {
            if (Head == null)
            {
                Head = p;
                Tail = p;
            }
            tail.Next = p;
            tail = p;
        }
        public void Remove(Node_Event p)
        {
            if (Head == null)
                return;
            Node_Event q = Head;
            while (q!=null)
            {
                if (q.Next == p)
                {
                    if (q.Next == tail) tail = q;
                    q.Next = p.Next;
                    return;
                }
                q = q.Next;
            }
        }
    }
}
