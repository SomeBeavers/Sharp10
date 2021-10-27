using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace InterpolatedString_nuget
{
    [InterpolatedStringHandler]
    public ref struct NugetLogHandler
    {
        public NugetLogHandler(int literalLength, int formattedCount)
        {
        }

        public void AppendLiteral(string literal) { }
        public void AppendFormatted(string str) { }
    }

    public class NugetLogger
    {
        [StringFormatMethod("format")]
        public static void Log(string format, params object[] args) => throw null!;

        public static void Log(ref NugetLogHandler handler) => throw null!;
        
    }

    public class Use
    {
        public void Test(IFormatProvider provider, int arg1, string arg2)
        {
            NugetLogger.Log("{0} {1}", "string", 1.ToString());
        }
    }
}