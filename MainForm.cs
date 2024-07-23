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
        private Theme theme;
        private FindAndReplace findAndReplace;

		private bool prevEventWasGetPrevStep = false;
        private bool prevEventWasGetNextStep = false;


        public MainForm()
        {
            InitializeComponent();
			PrevAndNextStep.textStack.Clear();
			PrevAndNextStep.deletedTextStack.Clear();
			richTextBox_Main.Text = string.Empty;
			label_currentFile.Text = string.Empty;

            theme = new Theme(this, richTextBox_Main);
            findAndReplace = new FindAndReplace(richTextBox_Main);
        }


        private void label_currentFile_MouseEnter(object sender, EventArgs e)
        {
            if (label_currentFile.Text != "")
            {
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(label_currentFile, label_currentFile.Text);
            }
        }


        // РАЗДЕЛ ФАЙЛ
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_File.Open(richTextBox_Main, label_currentFile);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_File.Save(richTextBox_Main, label_currentFile);
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_File.SaveAs(richTextBox_Main, label_currentFile);
        }

        private void новоеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_File.NewWindow();
        }



        //РАЗДЕЛ РЕДАКТОР
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Menu_Editor.ChangeFont(richTextBox_Main);
		}

		private void цветToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Menu_Editor.ChangeColor(richTextBox_Main);
		}

		private void поЛевомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Menu_Editor.ChangeAlignmentLeft(richTextBox_Main);
		}

		private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Menu_Editor.ChangeAlignmentCenter(richTextBox_Main);
		}

		private void поПравомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Menu_Editor.ChangeAlignmentRight(richTextBox_Main);
		}




		// РАЗДЕЛ ТЕМА
		private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			theme.SetLightTheme();
		}

		private void темнаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			theme.SetDarkTheme();
		}

		private void контрастнаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			theme.SetContrastingTheme();
		}

		private void морскаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			theme.SetMarineTheme();
		}

		private void васильковаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			theme.SetCornflowerTheme();
		}

		private void травянаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			theme.SetHerbalTheme();
		}

		private void древеснаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			theme.SetWoodTheme();
		}

		private void морковнаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			theme.SetCarrotTheme();
		}

		private void вишнёваяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			theme.SetCherryTheme();
		}

		private void сиреневаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			theme.SetLilacTheme();
		}

		private void лимоннаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			theme.SetLemonTheme();
		}

		private void кремоваяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			theme.SetCreamTheme();
		}

		//РАЗДЕЛ ОПЦИИ
		private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchText = Prompt.ShowDialog("Введите текст для поиска:", "Поиск");
			if(searchText!="")
				findAndReplace.Search(searchText);
        }

        private void заменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			string oldText = Prompt.ShowDialog("Введите текст для замены:", "Замена");
			if (!(string.IsNullOrEmpty(oldText)))
			{
				string newText = Prompt.ShowDialog("Введите новый текст:", "Замена");
				findAndReplace.Replace(oldText, newText);
			}
		}


        //ОБ АВТОРАХ
        private void обАвторахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филимонов Роман Сергеевич\nСмирнов Владислав Сергеевич\nВольхин Николай Николаевич\n\nВГУ, ПММ, 2 курс\n\n2024", "Об авторах", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        // ВЕРНУТЬСЯ НА ШАГ НАЗАД И НА ШАГ ВПЕРЕД
        private void pictureBox_prevStep_Click(object sender, EventArgs e)
        {
			prevEventWasGetPrevStep = true;

            if (PrevAndNextStep.firstClick)
			{
				MessageBox.Show("Внимание! Данная функция корректно работает только с изменением символов текста!\n\n" +
					"Со шрифтом, цветом и выравниванием она может работать некорректно!\n\nПриносим свои извинения.", "Предупреждение", 
					MessageBoxButtons.OK, MessageBoxIcon.Warning);

				PrevAndNextStep.firstClick = false;
				return;
			}

			if (PrevAndNextStep.textStack.Count >= 1)
			{
                PrevAndNextStep.ignoreTextChange = true;				// игнорируем возвращение на шаг назад для обработчика изменения текста, 
                richTextBox_Main.Text = PrevAndNextStep.GetPrevStep();  // чтобы не образовалось бесконечного цикла 
                PrevAndNextStep.ignoreTextChange = false;
			}
        }
        private void pictureBox_nextStep_Click(object sender, EventArgs e)
        {
            if (prevEventWasGetPrevStep || prevEventWasGetNextStep)     // функция работает только тогда, когда 
            {															// перед этим была нажата одна из стрелок
                prevEventWasGetPrevStep = false;
                prevEventWasGetNextStep = true;

                if (PrevAndNextStep.deletedTextStack.Count >= 1)
					richTextBox_Main.Text = PrevAndNextStep.GetNextStep();
            }
			else
			{
				MessageBox.Show("Данная функция работает только после возвращения на шаг назад!", "Уведомление", 
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
        }

		// обработчик события изменения текста
        private void richTextBox_Main_TextChanged(object sender, EventArgs e)
		{ 
            if (!PrevAndNextStep.ignoreTextChange)   // отслеживание любого изменения текста, кроме нажатия на стрелку назад
			{
                prevEventWasGetPrevStep = false;				
                string currText = richTextBox_Main.Text;
                PrevAndNextStep.textStack.Push(currText);       // сохраняем в стек каждое новое введенное изменение

                if (!prevEventWasGetNextStep)					// если произошло любое изменение текста кроме нажатия на стрелки, 
                    PrevAndNextStep.deletedTextStack.Clear();   // то очищаем стек удаленных вариантов
            }
        }

        private void pictureBox_prevStep_MouseEnter(object sender, EventArgs e)
        {
			ToolTip toolTip=new ToolTip();
			toolTip.SetToolTip(pictureBox_prevStep, "Вернуться на шаг назад");
        }

        private void pictureBox_nextStep_MouseEnter(object sender, EventArgs e)
        {
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(pictureBox_nextStep, "Вернуть");
        }



		// КОПИРОВАТЬ, ВСТАВИТЬ, ВЫРЕЗАТЬ, ВЫДЕЛИТЬ ВСЕ
        private void richTextBox_Main_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                richTextBox_Main.ContextMenuStrip = contextMenuStrip;
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			MenuStrip.CopyText(richTextBox_Main);
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			MenuStrip.PasteText(richTextBox_Main);
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			MenuStrip.CutText(richTextBox_Main);
        }

        private void выделитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
			MenuStrip.SelectAll(richTextBox_Main);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			MenuStrip.Delete(richTextBox_Main);
        }

        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
			richTextBox_Main.DeselectAll();
            richTextBox_Main.SelectionBackColor = richTextBox_Main.BackColor;
        }

       
    }
}

