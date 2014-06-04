using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    public static class Extensions
    {
        public static StringBuilder Substring (this StringBuilder sb, int index, int length)
        {
            string tempString = sb.ToString();
            tempString = tempString.Substring(index, length);
            sb.Clear();
            sb.Append(tempString);
            return sb;
        }
    }
    class Substring
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("some text and more text");
            Console.WriteLine(sb.Substring(5, 15).ToString());
        }
    }
}
