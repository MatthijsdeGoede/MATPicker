namespace MATPicker
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    internal class Log
    {
        private static SortedSet<string> lines = new();

        public static RichTextBox Box { get; set; }

        public static bool ShowErrorsOnly { get; set; }

        public static void AppendPicked(string data)
        {
            lines.Add($"<SUCCESS> Picked {data.Substring(data.LastIndexOf(".") + 1)}: {data}");
        }

        public static void AppendMissing(string data)
        {
            AppendError($"Failed to locate {data.Substring(data.LastIndexOf(".") + 1)}: {data}");
        }

        public static void AppendError(string data)
        {
            lines.Add($"<ERROR> {data}");
        }

        public static void Clear()
        {
            lines.Clear();
            Box.Clear();
        }

        public static void Show()
        {
            Box.Text = "";
            foreach (string line in lines)
            {
                bool errorLine = line.StartsWith("<ERROR>");
                Box.SelectionColor = errorLine ? System.Drawing.Color.Red : System.Drawing.Color.DarkGreen;

                if (!ShowErrorsOnly || errorLine)
                {
                    Box.AppendText($"{line}\r\n");
                }
            }
        }
    }
}
