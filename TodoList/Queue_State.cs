﻿using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class Queue_State
    {
        Node_State head = new Node_State();
        Node_State tail = new Node_State();

        public Queue_State() 
        {
            Head = null;
            Tail = null;
        }

        public Node_State Head { get => head; set => head = value; }
        public Node_State Tail { get => tail; set => tail = value; }

        public void Push(Node_State p)
        {
            if (Head == null)
            {
                Head = p;
                Tail = p;
            }
            else
            {
                Tail.Next = p;
                Tail = p;
            }
            
        }
        public void Pop()
        {
            if (Head == null)
                return;
            if (Head == Tail)
            {
                Head = null;
                Tail = null;
                return;
            }
            Node_State p = Head;
            Head = Head.Next;
            p = null;
        }

    }
}
