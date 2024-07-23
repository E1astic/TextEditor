using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public class Menu_File
    {
        private static string path = "";

        public static void SetPath(string _path)
        {
            path = _path;
        }

        public static string getPath()
        {
            return path;
        }
        public static void Open(RichTextBox textBox, Label currentFile)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "RTF (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                if (path.EndsWith("txt"))
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        textBox.Text = reader.ReadToEnd();
                    }
                }
                else
                {
                    textBox.LoadFile(path);
                }
                currentFile.Text = openFileDialog.FileName;
            }
        }

        public static void Save(RichTextBox textBox, Label currentFile)
        {
            if (path != "")
            {
                if (path.EndsWith("txt"))
                {
                    using(StreamWriter writer=new StreamWriter(path))
                    {
                        writer.WriteLine(textBox.Text);
                    }
                }
                else
                {
                    textBox.SaveFile(path);
                }
                MessageBox.Show("Файл успешно сохранен.", "Уведомление");
            }
            else
            {
                SaveAs(textBox, currentFile);
            }
        }
        public static void SaveAs(RichTextBox textBox, Label currentFile)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "RTF (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;

                if (path.EndsWith("txt"))
                {
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine(textBox.Text);
                    }
                }
                else
                {
                    textBox.SaveFile(path);
                }

                MessageBox.Show("Файл успешно сохранен.", "Уведомление");
                currentFile.Text = path;
            }

        }
        public static void NewWindow()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
