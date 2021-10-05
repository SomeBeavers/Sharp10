using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MyNamespace
{
    [InterpolatedStringHandler]
    public struct StructHandler
    {
        public StructHandler(int t, int t1, string name, out bool b) => b = false;
        public StructHandler(int t, int t1, A a = null)
        {
            Console.WriteLine("StructHandler(int t, int t1, A a = null)");
        }

        public StructHandler(int t, int t1, out bool b)
        {
            Console.WriteLine("StructHandler(int t, int t1, out bool b)");
            b = false;
        }

        public StructHandler(int t, int t1, params int[] listInt)
        {
        }

        internal void AppendFormatted(string s, bool b)
        {
        }

        internal void AppendFormatted(List<string> list, bool b  = false)
        {
        }
        internal void AppendFormatted(IEnumerable<string> list)
        {
        }

        internal void AppendFormatted<T>(T t)
        {
            Console.WriteLine("1");
        }

        //internal static void AppendFormatted<T>(T t)
        //{
        //    Console.WriteLine("1");
        //}

        internal void AppendFormatted(DateTime dt, string format, int alignment)
        {
        }
        internal void AppendFormatted(in DateTime dt, int alignment)
        {
        }
        internal void AppendFormatted(params string[] strings)
        {
        }

        internal void AppendLiteral(string s)
        {
        }
    }

    [InterpolatedStringHandler]
    public static class StaticClassHandler
    {
    }

    public static class AttributeOnStruct
    {
        private const string S = "s";

        public static string Log(
            this string s, 
            [InterpolatedStringHandlerArgument(S)] StructHandler handler)
        {
            handler.AppendFormatted(new List<string>());
            return null;
        }

        public static string Log2(
            this string s, 
            [InterpolatedStringHandlerArgument()] StructHandler handler)
        {
            return null;
        }
        public static string Log3(
            [InterpolatedStringHandlerArgument("a")] StructHandler handler, A a = null)
        {
            return null;
        }
        public static string Log4(StructHandler handler, A a = null)
        {
            return null;
        }
        public static string Log5([InterpolatedStringHandlerArgument("a")] StructHandler handler, params int[] a)
        {
            return null;
        }

        public static async Task LogAsync([InterpolatedStringHandlerArgument()]StructHandler handler)
        {
        }
    }

    public class Use4
    {
        private void Test(List<string> parameter, List<int> listInt)
        {
            "".Log($"{parameter}");
            "".Log2($"{parameter}");
            AttributeOnStruct.Log5(a: listInt.ToArray(), handler:$"{listInt} test");

            var i = DateTime.Now;
            "".Log($"{i, 11}");

            "".Log($"{parameter.ToArray()}");

            var a = new A();
            AttributeOnStruct.Log3(a: new A(), handler:$"{parameter} test");
            AttributeOnStruct.Log4(handler:$"{parameter} test");

            AttributeOnStruct.LogAsync($"{parameter}");
        }
    }
}