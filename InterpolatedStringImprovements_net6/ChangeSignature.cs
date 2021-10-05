// Sharp10 InterpolatedStringImprovements_net6 ChangeSignature.cs

using System.Runtime.CompilerServices;

namespace InterpolatedStringImprovements_net6
{
    [InterpolatedStringHandler]
    public class ChangeSignature
    {
        public ChangeSignature(int t, int t2, string loggerName, string optionalParameter = "")
        {
        }

        public void AppendLiteral(string s)
        {
        }
    }

    class ChangeSignature_Logger
    {
        public static void Log(string loggerName, [InterpolatedStringHandlerArgument("loggerName")]ChangeSignature handler)
        {
        }
    }

    class Use6
    {
        private void Test()
        {
            ChangeSignature_Logger.Log(null, $"test");
        }
    }
}