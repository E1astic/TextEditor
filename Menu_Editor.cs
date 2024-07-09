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
    public class Menu_Editor
    {
        private static Font font;
        private static int size;
        private static Color color;
        FontStyle style;  //жирный, курсив и тд
        private static ContentAlignment textAlign;
        TextBox textBox;
       

        public Menu_Editor(TextBox textBox)
        {            
            this.textBox = textBox;
        }

        
        public static void setFont(Font _font)   // устанавливаем шрифт
        {
            
        }
        public static void setSize(int _size)   // устанавливаем размер шрифта
        {
            
        }
        public static void setColor(Color _color)   // устанавливаем цвет
        {

        }
        public static void setStyle()   // устанавливаем стиль
        {

        }
        public static void setAlignment()  // устанавливаем выравнивание
        {

        }

        public static void setAllParametres()   // применяем все заданные параметры к переданному объекту
        {
            
        }
        
    }
}
