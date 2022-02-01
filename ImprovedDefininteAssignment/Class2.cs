using ClassLibrary1;

using System;
using System.Security.AccessControl;
using System.Text;
using System.Xml.Linq;
#nullable disable
namespace ClassLibrary1
{
    public struct MyStruct
    {
        private readonly object a;
    }
}

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public void Method(object value)
        {
            string stringValue = value as string;
            if (stringValue != null || value == null)
            {
                DoSomethingWithStringsOrNull(stringValue);
            }
        }

        private void DoSomethingWithStringsOrNull(string stringValue)
        {
        }


        public static MyObject Property { get; set; }
    }

    internal class MyObject
    {
    }

    internal class Program2
    {
        private static void Main(string[] args)
        {
            var result = GuessWhatWillHappen();
            Console.WriteLine($"Is result null? {result == null}");
            Console.ReadLine();

            var place = new
            {
                Metadata = (IDictionary<string, string>)null
            };
            // ...
            var sb = new StringBuilder();
            // ...
            if (place.Metadata?.TryGetValue("erpid", out var erpid) ?? false)
            {
                sb.Append(" | ");
                sb.Append("erpid=");
                sb.Append(erpid);
            }

        }

        private static string GuessWhatWillHappen()
        {
            SetStringValue();
            string foo = null;

            void SetStringValue()
            {
                foo = "bar";
            }

            return foo;
        }
    }

}