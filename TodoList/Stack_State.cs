using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace TodoList
{
    public class Stack_State
    {
        Node_State head = new Node_State();
        public Node_State Head { get => head; set => head = value; }
        public Stack_State()
        {
            Head = null;
        }

        public void Push(Node_State value)
        {
            if (Head == null) 
            {
                Head = value;
                return;
            }
            value.Next = Head;
            Head = value;
        }
        public void Pop()
        {
            if (Head == null) return;
            Node_State p = Head;
            Head = Head.Next;
            p = null;
        }
    }
}
