using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_File.Open(textBox_Main);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_File.Save(textBox_Main);
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_File.SaveAs(textBox_Main);
        }

        private void новоеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_File.NewWindow();
        }
    }
}
