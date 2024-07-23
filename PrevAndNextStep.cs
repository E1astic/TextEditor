using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    public class PrevAndNextStep
    {
        public static Stack<string> textStack = new Stack<string>();
        public static Stack<string> deletedTextStack = new Stack<string>();
        public static bool ignoreTextChange = false;
        public static bool firstClick = true;

        public static string GetPrevStep()
        {
            string result = "";
            if(textStack.Count >= 1) 
            { 
                deletedTextStack.Push(textStack.Peek());
                textStack.Pop();

                if (textStack.Count >= 1)
                    result = textStack.Peek();
                else
                    result = "";
            }
            return result;
        }

        public static string GetNextStep() 
        {
            string result = "";
            if(deletedTextStack.Count >= 1) 
            { 
                result = deletedTextStack.Peek();
                deletedTextStack.Pop();
                
            }
            return result;
        }
    }
}
