using System;
using StringFormat.Client;
using StringFormat.Core;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---HTML格式----");
            var p = new TextProcessor();
            p.AppendList(new[] { "foo", "bar", "baz" });
            Console.WriteLine(p);


            Console.WriteLine("---Markdown格式----");
            p.Clear();
            p.SetListStrategy(OutputFormat.Markdown);
            p.AppendList(new [] { "foo", "bar", "baz" });
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
