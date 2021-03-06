using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

using JetBrains.Annotations;

namespace InterpolatedStringImprovements_net6.Playground;

[InterpolatedStringHandler]
public ref struct LogHandler
{
    public LogHandler(int t, int t2)
    {
    }

    public LogHandler(int t, int t2, string name, Logger handler)
    {
    }

    public void AppendFormatted(string append)
    {
    }
    public void AppendFormatted(int append)
    {
    }
    public void AppendFormatted(A append)
    {
    }

    public void AppendFormatted<T>(T value, int alignment, string? format)
    {
    }

    public void AppendLiteral(string append)
    {
    }
}
[InterpolatedStringHandler]
public ref struct LogHandler2
{
    public LogHandler2(int t, int t2)
    {
    }

    public LogHandler2(int t, int t2, string name, Logger handler)
    {
    }

    public void AppendFormatted(string append)
    {
    }
    public void AppendFormatted(int append)
    {
    }
    public void AppendFormatted(A append)
    {
    }

    public void AppendFormatted<T>(T value, int alignment, string? format)
    {
    }

    public void AppendLiteral(string append)
    {
    }
}



public class Logger
{
    public static void LogFormatted(LogHandler handler)
    {
    }
    //public static void Log(LogHandler2 handler)
    //{
    //}

    public void LogFormatted(string name, [InterpolatedStringHandlerArgument("name", "")] LogHandler handler)
    {
    }

    //[StringFormatMethod("handler")]
    //public static void LogFormatted(string handler, params object[] args)
    //{
    //}

    //public static void LogFormatted([InterpolatedStringHandlerArgument("")] LogHandler handler)
    //{
    //}


    [StringFormatMethod("formatString")]
    public static void Log(string formatString, params object[] args)
    {
        // some custom logic
        Console.WriteLine(formatString, args);
    }

    [StringFormatMethod("handler")]
    public void LogFormatted(string name, string handler, params object[] args)
    {
    }
}

public class Use
{
    public string Name { get; set; }

    public void Test(A a)
    {
        Debug.Assert(true, $"{Name}");
        new Logger().LogFormatted("name", $"{Name} {1}");

        //new Logger().Log("{0} {1}", Name, 1);

        new Logger().LogFormatted("1", "{0} {1}", Name, 1);

        Logger.Log("{0, 11:D} test", a);
    }
}

public class A
{
}