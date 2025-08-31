
// Amir Moeini Rad
// August 2025

// Main Concept: Strings in C#
// String methods in this example: Length, CompareTo, Equals, ToLower, IndexOf, Split, Substring, Trim
// StringBuilder class and its methods: Append, Insert, Capacity, MaxCapacity

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
            Console.WriteLine("Comparison result for s1: {0} and s2: {1}: {2}", s1, s2, s1.CompareTo(s2));
            Console.WriteLine("Equality checking of s1: {0} and s2: {1}: {2}", s1, s3, s1.Equals(s3));
            Console.WriteLine("Equality checking of s3: {0} with lower case s1: {1} ({2}): {3}", s3, s1, s1.ToLower(), s3.Equals(s1.ToLower()));
            Console.WriteLine("The index of 'A' in s1: {0} is: {1}", s1, s1.IndexOf("A"));
            
            
            Console.WriteLine("\nThe individual words of s4: '{0}' are:", s4);
            string[] words = s4.Split();
            foreach (string word in words)
            {
                Console.WriteLine("{0}", word);
            }


            Console.WriteLine("\nThe substring of s4: '{0}' from index 3 with a length of 10 is:\n {1}", s4, s4.Substring(3, 10));
            
            
            Console.WriteLine("\nThe string s5: '{0}' after trimming becomes\n'{1}'", s5, s5.Trim());


            // You can't change or modify a string.
            // Strings are immutable.
            // string myStr = "abcd";
            // myStr[1] = "e";


            Console.WriteLine();


            // Using a quote in a string
            Console.WriteLine("\"Hello World!\"");


            // Using a backslash in a string
            // Method 1: You need to escape it with another backslash.
            Console.WriteLine("My Code: C:\\Books\\TYCSharp\\Originals\\");


            // A verbatim string literal
            // Method 2: Use @ before the string.
            Console.WriteLine(@"My Code: C:\Books\TYCSharp\Originals\");
            Console.WriteLine(@"""Hello World!""");


            // Manipulating strings
            // The 'StringBuilder' class helps you to manipulate strings.
            StringBuilder name = new StringBuilder();
            string buffer;
            int marker = 0;

            Console.Write("\nEnter your first name: ");
            buffer = Console.ReadLine();
            if (buffer != null)
            {
                name.Append(buffer);
                marker = name.Length;
            }

            Console.Write("Enter your last name: ");
            buffer = Console.ReadLine();
            if (buffer != null)
            {
                name.Append(" ");
                name.Append(buffer);
            }

            Console.Write("Enter your middle name: ");
            buffer = Console.ReadLine();
            if (buffer != null)
            {
                name.Insert(marker + 1, buffer);
                name.Insert(marker + 1 + buffer.Length, " ");
            }

            Console.WriteLine("Full name: {0}", name);

            
            Console.WriteLine("\nInfo about the StringBuilder string:");
            Console.WriteLine("value: {0}", name);

            // StringBuilder.Capacity gets or sets the maximum number of characters that can be contained in the memory
            // allocated by the current instance of StringBuilder.
            Console.WriteLine("Capacity: {0}", name.Capacity);

            // StringBuilder.MaxCapacity gets the maximum capacity of this instance of StringBuilder.
            Console.WriteLine("Maximum Capacity: {0}", name.MaxCapacity);

            // StringBuilder.Length gets or sets the length of the current StringBuilder object.
            Console.WriteLine("Length: {0}", name.Length);


            Console.WriteLine("\nDone.");
        }
    }
}