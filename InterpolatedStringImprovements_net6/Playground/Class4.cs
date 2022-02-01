// Sharp10 InterpolatedStringImprovements_net6 Nullable.cs

using JetBrains.Annotations;

namespace MyNamespace11
{
    // Sharp10 InterpolatedStringImprovements_net6 Constructors.cs

    using System;
    using System.Runtime.CompilerServices;


    namespace MyNamespace
    {
        [InterpolatedStringHandler]
        public struct MyHandler
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

            public MyHandler(int t, int t1, string loggerName)
            {
                Console.WriteLine($"{loggerName}: MyHandler(int t, int t1, string loggerName)");
            }
            public MyHandler(int t, int t1)
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

            public static void Log(object simpleObject)
            {
            }

            public static void Log(string name, [InterpolatedStringHandlerArgument("name")] MyHandler handler)
            {
            }
            //public static void Log([InterpolatedStringHandlerArgument("name")] MyHandler handler, string name = "test name")
            //{
            //}


            [StringFormatMethod("handler")]
            public static void LogFormat(string name, string handler,  params int[] args)
            {

            }
            //[StringFormatMethod("handler")]
            //public void Log(string name, string handler, params object[] args)
            //{
            //}
        }

        public class Constructors
        {
            private void Test(string? parameter1, MyHandlerLogger handlerLogger, string string_parameter)
            {
                MyHandlerLogger.Log("", $"{1} test");
                var empty = "";
                var args = 1;
                MyHandlerLogger.LogFormat("", "{0}", args);

                MyHandlerLogger.Log($"{1} test");
                MyHandlerLogger.Log("myLogger", $"{parameter1} test");

                MyHandlerLogger.Log(string_parameter, $"{parameter1} test");
            }
        }
    }
}