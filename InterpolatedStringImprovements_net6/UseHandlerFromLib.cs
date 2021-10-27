// Sharp10 InterpolatedStringImprovements_net6 UseHandlerFromLib.cs

using System.Runtime.CompilerServices;
using InterpolatedStringImprovements_net6_Lib;
using JetBrains.Annotations;

namespace InterpolatedStringImprovements_net61
{
    public class LogFromLib
    {
        public static void Log(HandlerFromLib handler)
        {
        }

        internal static void Log(bool b, HandlerFromLib handler)
        {
        }

        [StringFormatMethod("format")]
        public static void Log(bool b, string format, params object[] args)
        {
        }

        [StringFormatMethod("format")]
        public static void Log(string format, params object[] args)
        {
        }
    }

    public class UseHandlerFromLib
    {
        private void Test()
        {
            string localVar = 1.ToString();

            LogFromLib.Log(true, "{0}", localVar);
            LogFromLib.Log("{0} t", localVar);

            //LogFromLib.Log(true, $"{localVar} t");
        }
    }
}