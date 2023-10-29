using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*List_Event list_event = new List_Event();
            ReadFile.Read_File(list_event);
            Node_Event node_Event = list_event.Head;
            while (node_Event != null)
            {
                Console.WriteLine(node_Event.ToString());
                node_Event = node_Event.Next;
            }*/
        }
    }
}
