using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectToString
{
    class ObjectToString
    {
        static void Main(string[] args)
        {
            //Declare two string variables and assign them with “Hello” and “World”.
            //Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval).
            //Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string greating = helloWorld.ToString();

        }
    }
}
