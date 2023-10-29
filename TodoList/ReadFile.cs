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
        static public void Read_File(List_Event list_event)
        {
            string[] Data = File.ReadAllLines(@"D:\Data.txt");
            foreach (string s in Data)
            {
                Node_Event node_event = new Node_Event();
                string[] kq = s.Split(' ');
                while (kq[0].IndexOf("_") >= 0) kq[0]=kq[0].Replace("_", " ");
                node_event.Event = kq[0];
                DateTime temp = new DateTime(Int32.Parse(kq[6]), Int32.Parse(kq[5]), Int32.Parse(kq[4]), Int32.Parse(kq[1]), Int32.Parse(kq[2]), Int32.Parse(kq[3]));
                node_event.Deadline = temp;
                list_event.Add(node_event);
            }
        }
    }
}
