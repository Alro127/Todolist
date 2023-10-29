using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class ReadFile
    {
        public void Read_File(List_Event list_event)
        {
            string[] Data = File.ReadAllLines(@"D:\Data.txt");
            foreach (string s in Data)
            {
                Node_Event node_event = new Node_Event();
                string[] kq = s.Split(' ');
                node_event.Event = kq[0];
                node_event.Deadline.AddHours(Int32.Parse(kq[1]));

            }
        }
    }
}
