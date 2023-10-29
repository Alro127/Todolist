using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List_Event list_event = new List_Event();
        Stack_State undo_stack = new Stack_State();
        Stack_State redo_stack = new Stack_State();

        Queue_State queue = new Queue_State();
        void updateStack(List_Event list_event)
        {
            List_Event new_list = new List_Event();
            Node_Event p = list_event.Head;
            while (p!=null)
            {
                Node_Event new_node = new Node_Event();
                new_node.Event = p.Event;
                new_node.Deadline = p.Deadline;
                new_list.Add(new_node);
                p= p.Next;
            }
            Node_State node_state = new Node_State(new_list);
            undo_stack.Push(node_state);
        }
        void update(List_Event list_event)
        {
            checkedListBox1.Items.Clear();
            Node_Event p = list_event.Head;
            while (p != null)
            {
                if (p.Deadline.Date.CompareTo(DateTime.Today) == 0)
                    checkedListBox1.Items.Add(p.ToString());
                p = p.Next;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile.Read_File(list_event);
            updateStack(list_event);
            update(list_event);
        }
        string new_event=string.Empty;
        DateTime new_time = DateTime.Now;
        private void Add_btn_Click(object sender, EventArgs e)
        {
            Add_pnl.Visible = true;
            Add_pnl.Location = new Point(200, 230);
            Del_pnl.Visible = false;
            Fix_pnl.Visible = false;
            Search_pnl.Visible = false;
            Sort_pnl.Visible = false;
        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
            Del_pnl.Visible = true;
            Del_pnl.Location = new Point(200, 230);
            Add_pnl.Visible = false;
            Fix_pnl.Visible = false;
            Search_pnl.Visible = false;
            Sort_pnl.Visible = false;
        }

        private void Fix_btn_Click(object sender, EventArgs e)
        {
            Fix_pnl.Visible = true;
            Fix_pnl.Location = new Point(200, 230);
            Add_pnl.Visible = false;
            Del_pnl.Visible = false;
            Search_pnl.Visible = false;
            Sort_pnl.Visible = false;
        }

        private void Sort_btn_Click(object sender, EventArgs e)
        {
            Sort_pnl.Visible = true;
            Sort_pnl.Location = new Point(200, 230);
            Add_pnl.Visible = false;
            Fix_pnl.Visible = false;
            Search_pnl.Visible = false;
            Del_pnl.Visible = false;
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            Search_pnl.Visible = true;
            Search_pnl.Location = new Point(200, 230);
            Add_pnl.Visible = false;
            Fix_pnl.Visible = false;
            Del_pnl.Visible = false;
            Sort_pnl.Visible = false;
        }

        private void Add_tb_TextChanged(object sender, EventArgs e)
        {
            new_event = Add_tb.Text;
        }

        private void Add_dt_ValueChanged(object sender, EventArgs e)
        {
            new_time = Add_dt.Value;
        }

        private void Add_OK_btn_Click(object sender, EventArgs e)
        {
            Node_Event p = new Node_Event(new_event, new_time);
            list_event.Add(p);
            updateStack(list_event);
            update(list_event);
        }

        private void Undo_btn_Click(object sender, EventArgs e)
        {
            if (undo_stack.Head.Next != null)
            {
                Node_State node = new Node_State();
                node.State = undo_stack.Head.State;
                redo_stack.Push(node);
                undo_stack.Pop();
            }
            list_event = new List_Event();
            Node_Event p = undo_stack.Head.State.Head;
            while (p != null)
            {
                Node_Event q = new Node_Event();
                q.Event = p.Event;
                q.Deadline = p.Deadline;
                list_event.Add(q);
                p=p.Next;
            }
            update(list_event);
        }

        private void Redo_btn_Click(object sender, EventArgs e)
        {
            if (redo_stack.Head!= null)
            {
                Node_State node = new Node_State();
                node.State = redo_stack.Head.State;
                undo_stack.Push(node);
                redo_stack.Pop();
            }
            list_event = new List_Event();
            Node_Event p = undo_stack.Head.State.Head;
            while (p != null)
            {
                Node_Event q = new Node_Event();
                q.Event = p.Event;
                q.Deadline = p.Deadline;
                list_event.Add(q);
                p = p.Next;
            }
            update(list_event);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateFile.Update_File(list_event);
        }
    }
}
