using System;
using System.Text;

namespace String_Assignment
{
    internal class Program
    {
        static void Main()
        {
            // Creating three strings and concatenating them together
            string hello = "Hello,";
            string space = " ";
            string world = "World!";
            Console.WriteLine(hello + space + world);
            Console.ReadLine();

            // Writes the world string in upper case
            Console.WriteLine(world.ToUpper());
            Console.ReadLine();

            // Creating a StringBuilder to show how to add lines of text to a string.
            StringBuilder sb = new StringBuilder();
            sb.Append("This is a new string builder.\n");
            sb.Append("This will build a paragraph of text\n");
            sb.Append("as one string\n");
            sb.Append("using multiple appends.");
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
