// Sharp10 InterpolatedStringImprovements_net6 Nullable.cs

using JetBrains.Annotations;

namespace MyNamespace1
{
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

            public void Log(string name, [InterpolatedStringHandlerArgument("name", "")] MyHandler handler)
            {
            }
            public static void Log([InterpolatedStringHandlerArgument("name")] MyHandler handler, string name = "test name")
            {
            }

            //[StringFormatMethod("handler")]
            //public static void Log(string handler, string name = "test name", params object[] args)
            //{

            //}
            [StringFormatMethod("handler")]
            public void Log(string name, string handler, params object[] args)
            {
            }
        }

        public class Constructors
        {
            private void Test(string? parameter1, MyHandlerLogger handlerLogger, string string_parameter)
            {
                MyHandlerLogger.Log(name: "", handler: $"{1} test");
                //MyHandlerLogger.Log("{0}", /*caret*/"", ""); // <--------------- here

                MyHandlerLogger.Log($"{1} test");
                handlerLogger.Log("myLogger", $"{parameter1} test");

                handlerLogger.Log(string_parameter, $"{parameter1} test");
            }
        }
    }
}