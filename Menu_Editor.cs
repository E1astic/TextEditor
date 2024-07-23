using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
	public static class Menu_Editor
	{
		private static Font selectedFont = null;           // хранение выбранного шрифта
		private static Color selectedColor = Color.Black;  // хранение выбранного цвета

		public static Font GetFont()
		{
			return selectedFont;
		}

		public static Color GetColor() 
		{
			return selectedColor;
		}

		public static void ChangeFont(RichTextBox richTextBox)
		{
			FontDialog fontDialog = new FontDialog();
			Font currentFont = richTextBox.SelectionFont;

			fontDialog.Font = currentFont;

			if (fontDialog.ShowDialog() == DialogResult.OK)
			{
				if (richTextBox.SelectionLength > 0)
				{
					richTextBox.SelectionFont = fontDialog.Font;
				}
				else
				{
					richTextBox.Font = fontDialog.Font;
				}

				selectedFont = fontDialog.Font;
			}
		}

		public static void ChangeColor(RichTextBox richTextBox)
		{
			ColorDialog colorDialog = new ColorDialog();

			if (richTextBox.SelectionLength > 0)
			{
				colorDialog.Color = richTextBox.SelectionColor;
			}
			else
			{
				colorDialog.Color = richTextBox.ForeColor;
			}

			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				if (richTextBox.SelectionLength > 0)
				{
					richTextBox.SelectionColor = colorDialog.Color;
				}
				else
				{
					richTextBox.ForeColor = colorDialog.Color;
				}

				selectedColor = colorDialog.Color;
			}
		}

		public static void ChangeAlignmentLeft(RichTextBox richTextBox)
		{
			SetAlignment(richTextBox, HorizontalAlignment.Left);
		}

		public static void ChangeAlignmentCenter(RichTextBox richTextBox)
		{
			SetAlignment(richTextBox, HorizontalAlignment.Center);
		}

		public static void ChangeAlignmentRight(RichTextBox richTextBox)
		{
			SetAlignment(richTextBox, HorizontalAlignment.Right);
		}

		private static void SetAlignment(RichTextBox richTextBox, HorizontalAlignment alignment)
		{
			if (richTextBox.SelectionLength > 0)
			{
				int start = richTextBox.SelectionStart;
				int end = richTextBox.SelectionStart + richTextBox.SelectionLength;

                richTextBox.Select(start, end-start);
                richTextBox.SelectionAlignment = alignment;
                
            }
			else
			{
				richTextBox.SelectAll();
				richTextBox.SelectionAlignment = alignment;
			}
		}
	}
}