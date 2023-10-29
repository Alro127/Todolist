using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TodoList
{
    internal class UpdateFile
    {
        static public void Update_File(List_Event list_event) 
        {
            /*Node_Event node = list_event.Head;
            while (node != null)
            {
                string s = "";
                //while (node.Event.IndexOf(" ") >= 0) node.Event.Replace(" ", "_");
                s = s+ node.Event + " " + node.Deadline.Hour + " " + node.Deadline.Minute + " " + node.Deadline.Second + " " + node.Deadline.Day + " " + node.Deadline.Month + " " + node.Deadline.Year;
                File.WriteAllText(@"D:\Data.txt",s);
                node = node.Next;
            }*/
            StreamWriter sw;
            Node_Event node = list_event.Head;
            sw = new StreamWriter(@"D:\Data.txt");
            while (node != null)
            {
                string s = "";
               // while (node.Event.IndexOf(" ") >= 0) node.Event.Replace(" ", "_");
                s = s + node.Event + " " + node.Deadline.Hour + " " + node.Deadline.Minute + " " + node.Deadline.Second + " " + node.Deadline.Day + " " + node.Deadline.Month + " " + node.Deadline.Year;
                //File.WriteAllText(@"D:\Data.txt", s);
                sw.WriteLine(s);
                node = node.Next;
            }
            sw.Close();
        }

    }
}
