using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace A11;

[InterpolatedStringHandler]
public ref struct LogHandler
{
    public LogHandler(int t, int t2)
    {
    }

    public void AppendLiteral(string literal) { }
    public void AppendFormatted(string str) { }
}



public static class Logger
{
    [StringFormatMethod("format")]
    public static void Log(this string s, string format, params object[] args) => throw null!;

    public static void Log(this string s, LogHandler handler) => throw null!;
}

public class Use
{
    public void Test(IFormatProvider provider, string arg1, string arg2)
    {
        Logger.Log(s:"test", "{0}", arg1); // <--------- here
    }
}