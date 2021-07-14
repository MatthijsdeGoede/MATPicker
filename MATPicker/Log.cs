using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATPicker
{
    class Log
    {
        public static RichTextBox Box { get; set; }
        public static bool ShowErrorsOnly { get; set; }
        public static void Append(string data) 
        {
            Box.AppendText($"{data}\\n");
        }
        public static void AppendError(string data)
        {
            Box.AppendText($"<ERROR> {data}\\n");
        }
        public static void Clear() 
        {
            Box.Clear();
        }

        public static void Show()
        {
            string[] lines = Box.Lines;
            Box.Text = "";

            foreach (string line in lines)
            {
                bool errorLine = line.StartsWith("<ERROR>");
                Box.SelectionColor = errorLine ? System.Drawing.Color.Red : System.Drawing.Color.Black;

                if (!ShowErrorsOnly || errorLine) 
                {
                    Box.AppendText($"{line}\\n");
                }                
            }
        }


    }
}
