using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TextEditor
{
    public class MenuStrip
    {     
        public static void CopyText(RichTextBox richTextBox)
        {
            richTextBox.Copy();
        }

        public static void PasteText(RichTextBox richTextBox)
        {
            richTextBox.Paste();
        }

        public static void CutText(RichTextBox richTextBox)
        {
            richTextBox.Cut();
        }

        public static void SelectAll(RichTextBox richTextBox)
        {
            richTextBox.SelectAll();
        }

        public static void Delete(RichTextBox richTextBox)
        {
            if(richTextBox.SelectedText.Length > 0)
            {
                richTextBox.SelectedText = "";
            }
        }
    }
}
