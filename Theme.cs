using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{

	public class Theme
	{
		private static Color backgroundColor;
		private static Color textColor;
		private static Color buttonColor;

		private Form mainForm;
		private RichTextBox textBox;

		public Theme(Form form, RichTextBox textBox)
		{
			this.mainForm = form;
			this.textBox = textBox;

			SetLightTheme();
        }

        public static Color GetBackgroundColor()
        {
            return backgroundColor;
        }

        public static Color GetTextColor()
        {
            return textColor;
        }

        public static Color GetButtonColor()
        {
            return buttonColor;
        }

        public void SetLightTheme()
		{
			backgroundColor = Color.White;
			textColor = Color.Black;
			buttonColor = Color.LightGray;
			ApplyTheme();
		}

		public void SetDarkTheme()
		{
			backgroundColor = Color.FromArgb(55, 55, 55);
			textColor = Color.White;
			buttonColor = Color.Gray;
			ApplyTheme();
		}
		public void SetContrastingTheme()
		{
			backgroundColor = Color.Black;
			textColor = Color.Yellow;
			buttonColor = Color.Gray;
			ApplyTheme();
		}
		public void SetMarineTheme()
		{
			backgroundColor = Color.FromArgb(102, 204, 204);
			textColor = Color.Black;
			buttonColor = Color.Gray;
			ApplyTheme();
		}
		public void SetCornflowerTheme()
		{
			backgroundColor = Color.FromArgb(102, 102, 255);
			textColor = Color.White;
			buttonColor = Color.Gray;
			ApplyTheme();
		}
		public void SetHerbalTheme()
		{
			backgroundColor = Color.FromArgb(0, 153, 102);
			textColor = Color.Black;
			buttonColor = Color.Gray;
			ApplyTheme();
		}
		public void SetWoodTheme()
		{
			backgroundColor = Color.FromArgb(101, 67, 33);
			textColor = Color.White;
			buttonColor = Color.Gray;
			ApplyTheme();
		}
		public void SetCarrotTheme()
		{
			backgroundColor = Color.FromArgb(222, 132, 56);
			textColor = Color.Black;
			buttonColor = Color.Gray;
			ApplyTheme();
		}
		public void SetCherryTheme()
		{
			backgroundColor = Color.FromArgb(102, 0, 51);
			textColor = Color.White;
			buttonColor = Color.Gray;
			ApplyTheme();
		}
		public void SetLilacTheme()
		{
			backgroundColor = Color.FromArgb(204, 153, 255);
			textColor = Color.Black;
			buttonColor = Color.Gray;
			ApplyTheme();
		}
		public void SetLemonTheme()
		{
			backgroundColor = Color.FromArgb(220, 220, 0);
			textColor = Color.Black;
			buttonColor = Color.Gray;
			ApplyTheme();
		}
		public void SetCreamTheme()
		{
			backgroundColor = Color.FromArgb(247, 220, 176);
			textColor = Color.Black;
			buttonColor = Color.Gray;
			ApplyTheme();
		}

		private void ApplyTheme()
		{
			mainForm.BackColor = backgroundColor;
			textBox.BackColor = backgroundColor;
			textBox.ForeColor = textColor;

			foreach (ToolStripMenuItem menuItem in mainForm.MainMenuStrip.Items)
			{
				menuItem.BackColor = backgroundColor;
				menuItem.ForeColor = textColor;
				foreach (ToolStripItem dropDownItem in menuItem.DropDownItems)
				{
					if (dropDownItem is ToolStripMenuItem)
					{
						dropDownItem.BackColor = backgroundColor;
						dropDownItem.ForeColor = textColor;
					}
				}
			}
		}

		public static void ApplyThemeToPrompt(Form prompt)
		{
			prompt.BackColor = backgroundColor;
			foreach (Control control in prompt.Controls)
			{
				control.BackColor = backgroundColor;
				control.ForeColor = textColor;
			}
		}

		
	}

}
