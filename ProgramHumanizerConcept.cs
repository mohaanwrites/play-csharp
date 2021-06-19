using System;
using Humanizer;

namespace play_csharp
{
    partial class Program
    {
        private static void OutputHumanizerPackageConcepts()
        {
            Console.WriteLine("Man".Pluralize());
            Console.WriteLine("Men".Singularize());
            Console.WriteLine("Case".ToQuantity(100));
            Console.WriteLine("HelloWorld".Humanize());
            Console.WriteLine("HelloWorld".Camelize());
            Console.WriteLine("HelloWorld".Pascalize());
            Console.WriteLine("HelloWorld".Kebaberize());
            Console.WriteLine("hello_world".Hyphenate());
            Console.WriteLine("hello_world".Dasherize());
            Console.WriteLine("Hello World".Underscore());
            Console.WriteLine(In.TheYear(2001).Humanize());
        }
    }
}