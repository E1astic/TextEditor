using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
	public class FindAndReplace
	{
		private RichTextBox textBox;
		public int lastSearchIndex; // Переменная для отслеживания последнего найденного индекса
        
        private List<int> highlighted;


		public FindAndReplace(RichTextBox textBox)
		{
			this.textBox = textBox;
			lastSearchIndex = -1;
            this.highlighted = new List<int>();

            // обработчик события Click
            this.textBox.Click += TextBox_Click;
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            // сбросить выделение при клике
            int start = textBox.SelectionStart;
            int length = textBox.SelectionLength;
            textBox.SelectAll();
            textBox.SelectionBackColor = textBox.BackColor;
            textBox.DeselectAll();
            textBox.Select(start, length);

        }

        public void Search(string searchText)  // поиск текста и его выделение
        {
            // сброс всех предыдущих выделений
            textBox.SelectAll();
            textBox.SelectionBackColor = textBox.BackColor;
            textBox.DeselectAll();

            highlighted.Clear();

            int countFound = 0;
            string currentText = textBox.Text;

            if (searchText.Length <= currentText.Length)
            {
                for (int i = 0; i <= currentText.Length - searchText.Length; i++)
                {
                    if (currentText.Substring(i, searchText.Length) == searchText)
                    {
                        ++countFound;
                        textBox.Select(i, searchText.Length);
                        textBox.SelectionBackColor = Color.Yellow;
                        highlighted.Add(i);
                        i += searchText.Length - 1;
                    }
                }
                if (countFound > 0)
                {
                    MessageBox.Show("Найдено слов: " + countFound, "Уведомление");
                    return;
                }
            }
            MessageBox.Show("Данного текста не найдено в документе", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Replace(string oldText, string newText)
        {
            int index = 0;
            int countReplaces = 0;
            while ((index = textBox.Find(oldText, index, RichTextBoxFinds.None)) != -1)
            {
                // текущее форматирование
                textBox.Select(index, oldText.Length);
                Font currentFont = textBox.SelectionFont;
                Color currentColor = textBox.SelectionColor;

                // удаление старого текст
                textBox.SelectedText = "";

                // новый текст с сохранением форматирования
                textBox.SelectionFont = currentFont;
                textBox.SelectionColor = currentColor;
                textBox.SelectedText = newText;

                index += newText.Length;

                ++countReplaces;
            }
            MessageBox.Show("Сделано замен: " + countReplaces, "Уведомление", MessageBoxButtons.OK);
        }
    }

	public class Prompt
	{
		public static string ShowDialog(string text, string caption)
		{
			Form prompt = new Form()
			{
				Width = 500,
				Height = 150,
				FormBorderStyle = FormBorderStyle.FixedDialog,
				Text = caption,
				StartPosition = FormStartPosition.CenterScreen
			};
			Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Width = 400 };
			TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
			Button confirmation = new Button() { Text = "ОК", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
			confirmation.Click += (sender, e) => { prompt.Close(); };
			prompt.Controls.Add(textBox);
			prompt.Controls.Add(confirmation);
			prompt.Controls.Add(textLabel);
			prompt.AcceptButton = confirmation;

            prompt.FormClosing += (sender, e) => {
                if (prompt.DialogResult == DialogResult.None) // если результат не установлен
                    prompt.DialogResult = DialogResult.Cancel; // устанавливаем результат на "Отмена"
            };

            Theme.ApplyThemeToPrompt(prompt);

			if (prompt.ShowDialog() != DialogResult.OK)
				return "";
			else
				return textBox.Text;

            
        }
      
    }
}
