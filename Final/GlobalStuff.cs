using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal static class GlobalStuff
    {
        public static MainWindow mainWindow;

        public static string toggleCAPS(this string string_in)
        {
            string string_out = "";
            foreach (char c in string_in)
            {
                if (char.IsUpper(c))
                {
                    string_out += char.ToLower(c);
                }
                else
                {
                    string_out += char.ToUpper(c);
                }
            }
            return string_out;
        }
    }


}
