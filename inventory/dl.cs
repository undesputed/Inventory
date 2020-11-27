using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    class dl
    {
        // Fixed Empty
        protected internal static char emptyChar { get; set; }
        protected internal static string emptyString { get; set; }
        protected internal static int emptyInt { get; set; }
        protected internal static double emptyDouble { get; set; }
        protected internal static bool emptyBool { get; set; }
        // condition boolean
        protected internal static bool Close_Execution { get; set; }
       
        // string holder
        protected internal static string SysName { get; set; }
        protected internal static string ProKey { get; set; }
        protected internal static string ActKey { get; set; }
        protected internal static bool loginHandle(KeyPressEventArgs e)
        {
            return char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) ? false : true;
        }
        protected internal static bool nameHandle(KeyPressEventArgs e)
        {
            string singleQuote = "'";
            return char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == singleQuote[0] || e.KeyChar == '-' ? false : true;
        }
        protected internal static bool passwordHandle(KeyPressEventArgs e)
        {
            string quote = "'";
            return e.KeyChar == ' ' || e.KeyChar == '"' || e.KeyChar == quote[0];
        }
        protected internal static bool numberHandle(KeyPressEventArgs e)
        {
            return !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        protected internal static bool emailHandle(KeyPressEventArgs e, string input)
        {
            bool temp = true;
             if (input.Length > 0)
            {
                if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar)
                    || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '@' || e.KeyChar == '-')
                {
                    temp = false;
                    if (e.KeyChar == '@')
                    {
                        if (input.Contains('@'))
                        {
                            temp = true;
                        }
                    }
                }
            }
            else
            {
                if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    temp = false;
                }
            }
            return temp;
        }
        protected internal static void Run_First()
        {
            dll.password_placeholder = " Password";
            dll.username_placeholder = " Username";
            dll.Cph = Color.Gray;
            dll.bstring = "";
            dll.pchar = '*';
            Close_Execution = false;
        }
    }
}
