
// Amir Moeini Rad
// August 2025

// Main Concept: Strings in C#

using System;
using System.Text;

namespace Strings
{
    class MyApp
    {
        public static void Main()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Strings in C#.NET.");
            Console.WriteLine("------------------\n");


            string s1 = "Amir";
            string s2 = "Amr";
            string s3 = "amir";
            string s4 = "C# is a great programming language!";
            string s5 = "   This is the target text   ";


            Console.WriteLine("Length of s1: {0} is {1} characters.", s1, s1.Length);
            Console.WriteLine("Comparison result for {0} and {1}: {2}", s1, s2, s1.CompareTo(s2));
            Console.WriteLine("Equality checking of {0} and {1}: {2}", s1, s3, s1.Equals(s3));
            Console.WriteLine("Equality checking of {0} with lower case {1} ({2}): {3}", s3, s1, s1.ToLower(), s3.Equals(s1.ToLower()));
            Console.WriteLine("The index of A in {0} is: {1}", s1, s1.IndexOf("A"));
            Console.WriteLine("\nThe individual words of '{0}' are:", s4);


            string[] words = s4.Split();
            foreach (string word in words)
            {
                Console.WriteLine(" {0}",word);
            }

            Console.WriteLine("\nThe substring of '{0}' fron index 3 of length 10 is:\n {1}", s4, s4.Substring(3, 10));
            Console.WriteLine("\nThe string '{0}' after trimming becomes\n'{1}'", s5, s5.Trim());

            // You can't change or modify a string.
            // string myStr = "abcd";
            // myStr[1] = "e";

            Console.WriteLine();

            // Using a quote in a string

            Console.WriteLine("\"Hello World!\"");
            
            // Using a backslash in a string

            Console.WriteLine("My Code: C:\\Books\\TYCSharp\\Originals\\");

            // A verbatim string literal

            Console.WriteLine(@"My Code: C:\Books\TYCSharp\Originals\");
            Console.WriteLine(@"""Hello World!""");

            // Manipulating strings

            StringBuilder name = new StringBuilder();
            string buffer;
            int marker = 0;

            Console.Write("\nEnter your first name: ");
            buffer = Console.ReadLine();

            if ( buffer != null )
            {
                name.Append(buffer);
                marker = name.Length;
            }

            Console.Write("\nEnter your last name: ");
            buffer = Console.ReadLine();

            if ( buffer != null )
            {
                name.Append(" ");
                name.Append(buffer);
            }

            Console.Write("\nEnter your middle name: ");
            buffer = Console.ReadLine();

            if ( buffer != null )
            {
                name.Insert(marker+1, buffer);
                name.Insert(marker+1+buffer.Length, " ");
            }

            Console.WriteLine("\n\nFull name: {0}", name);

            // Some stats....

            Console.WriteLine("\n\nInfo about StringBuilder string:");
            Console.WriteLine("value: {0}", name);
            Console.WriteLine("Capacity: {0}", name.Capacity);
            Console.WriteLine("Maximum Capacity: {0}", name.MaxCapacity);
            Console.WriteLine("Length: {0}", name.Length);

            Console.WriteLine();
        }
    }
}

// Strings or strings (String class objects) are immutable by nature.