using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public class Menu_File
    {
        private static string path = "";
        public static void Open(TextBox textBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;

                using(StreamReader reader=new StreamReader(openFileDialog.FileName)) 
                { 
                    string text = reader.ReadToEnd();
                    textBox.Text = text;
                }
                
            }
        }

        public static void Save(TextBox textBox)
        {
            if (path != "")
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(textBox.Text);
                }
                MessageBox.Show("Файл успешно сохранен.");
            }
            else
            {
                SaveAs(textBox);
            }
        }
        public static void SaveAs(TextBox textBox)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path=saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(textBox.Text);
                }
                MessageBox.Show("Файл успешно сохранен.");
            }
           
        }
        public static void NewWindow()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
