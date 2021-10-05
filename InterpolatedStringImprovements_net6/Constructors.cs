// Sharp10 InterpolatedStringImprovements_net6 Constructors.cs

using System;
using System.Runtime.CompilerServices;


namespace MyNamespace
{
    [InterpolatedStringHandler]
    public class MyHandler
    {
        public MyHandler(int t, int t1, string loggerName, MyHandlerLogger logger)
        {
            Console.WriteLine("MyHandler(int t, int t1, string loggerName, MyHandlerLogger logger)");
        }

        public MyHandler(int t, int t1, in string loggerName, MyHandlerLogger logger, out bool isValid)
        {
            Console.WriteLine("MyHandler(int t, int t1, string loggerName, MyHandlerLogger logger, out bool isValid)");
            isValid = false;
        }

        public MyHandler(int t, int t1, out string loggerName)
        {
            loggerName = "";
            Console.WriteLine($"{loggerName}: MyHandler(int t, int t1, string loggerName)");
        }

        public MyHandler(int t, int t1)
        {
            Console.WriteLine($"MyHandler(int t, int t1)");
        }
        public MyHandler(int t, int t1, params int[] numbers)
        {
            Console.WriteLine($"MyHandler(int t, int t1)");
        }

        //public MyHandler(int t, int t1, string loggerName, string s2, out bool b)
        //{
        //    Console.WriteLine($"{loggerName}: MyHandler(int t, int t1, string loggerName)");
        //    b = false;
        //}

        public void AppendFormatted(string s)
        {
        }
        public void AppendFormatted(int t)
        {
        }

        public void AppendLiteral(string s)
        {

        }
    }

    public class MyHandlerLogger
    {
        public static void Log(string simpleString)
        {
        }
        public static void Log(MyHandler handler)
        {
        }
        public static void Log([InterpolatedStringHandlerArgument("numbers")]MyHandler handler, params int[] numbers)
        {
        }

        public static void Log(object simpleObject)
        {
        }

        public void Log(string name, [InterpolatedStringHandlerArgument("name", "")]MyHandler handler)
        {
        }
        public static void Log([InterpolatedStringHandlerArgument("name")]MyHandler handler, out string name)
        {
            name = null;
        }
    }

    public class Constructors
    {
        private void Test(string parameter1, MyHandlerLogger handlerLogger, string string_parameter)
        {
            const string const_local_string = "";
            var name = "";

            MyHandlerLogger.Log(name: out name, handler:$"{1} test");
            MyHandlerLogger.Log($"{1} test");
            MyHandlerLogger.Log($"test {const_local_string}");

            MyHandlerLogger.Log(numbers: new[] { 1, 2, 3 }, handler: $"{1} test");

            handlerLogger.Log("myLogger", $"{parameter1} test");

            handlerLogger.Log(string_parameter, $"{parameter1} test");
        }
    }
}