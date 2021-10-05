// Sharp10 InterpolatedStringImprovements_net6 UseHandlerFromLib.cs

using InterpolatedStringImprovements_net6_Lib;

namespace InterpolatedStringImprovements_net6
{
    public class LogFromLib
    {
        public static void Log(HandlerFromLib handler)
        {
        }
    }

    public class UseHandlerFromLib
    {
        private void Test()
        {
            LogFromLib.Log($"");
        }
    }
}