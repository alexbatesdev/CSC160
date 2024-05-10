using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class ExtensionMethods
    {
        public static void Execute()
        {
            string message = "Hello, World!";

            Console.WriteLine("Size O' {0} is {1}", message, message.Length);

            Console.WriteLine("Is {0} title cased? {1}", message, message.isFirstCap());

            Console.WriteLine(message.AppendSttring("Oops typo lol"));
        }
    }
    
    public static class StringyHelper
    {
        //The helpeer specifically works because of the "this" keyword
        public static bool isFirstCap(this string strIn)
        {
            return char.IsUpper(strIn[0]);
        }

        public static string AppendSttring(this string incoming, string append)
        {
            return incoming + append;
        }
    }
}
