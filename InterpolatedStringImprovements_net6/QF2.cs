// Sharp10 InterpolatedStringImprovements_net6 QF2.cs

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace InterpolatedStringImprovements_net6
{
    [InterpolatedStringHandler]
    public ref struct DefaultInterpolatedStringHandler
    {
        public DefaultInterpolatedStringHandler(int literalLength, int formattedCount, string name, out bool b)
        {
            throw new NotImplementedException();
        }

        public string ToStringAndClear()
        {
            throw new NotImplementedException();
        }

        public void AppendLiteral(string value)
        {
            throw new NotImplementedException();
        }

        public void AppendFormatted<T>(T value)
        {
            throw new NotImplementedException();
        }

        public void AppendFormatted<T>(T value, string? format)
        {
            throw new NotImplementedException();
        }

        public void AppendFormatted<T>(T value, int alignment)
        {
            throw new NotImplementedException();
        }

        //public void AppendFormatted<T>(T value, int alignment, string? format)
        //{
        //    throw new NotImplementedException();
        //}

        public void AppendFormatted(ReadOnlySpan<char> value)
        {
            throw new NotImplementedException();
        }

        public void AppendFormatted(ReadOnlySpan<char> value, int alignment = 0, string? format = null)
        {
            throw new NotImplementedException();
        }

        public void AppendFormatted(string? value)
        {
            throw new NotImplementedException();
        }

        public void AppendFormatted(string? value, int alignment = 0, string? format = null)
        {
            throw new NotImplementedException();
        }

        public void AppendFormatted(object? value, int alignment = 0, string? format = null)
        {
            throw new NotImplementedException();
        }
    }

    public class Logger
    {
        public static void Log(string loggerName, [InterpolatedStringHandlerArgument("loggerName")]DefaultInterpolatedStringHandler handler)
        {
        }
        public static void Log(string handler)
        {
        }

        [StringFormatMethod("handler")]
        public static void Log(string name, string handler, params object[] args)
        {
        }
    }

    public class QF2
    {
        private string _parameter;

        private void Test(A a)
        {
            Logger.Log("", $"{a}");
            Logger.Log("{0}", " ");
            this._parameter = "parameter";
            var test = "test";
            Logger.Log("", "{0} = {1} {2}", a, this._parameter, test);
            Logger.Log("", "{0,1: D} = ", new List<string>());
        }
        private void Test2<T>(T a) where T: class, new()
        {
            Logger.Log("", $"{a}");
            Logger.Log("{0}", " ");
            this._parameter = "parameter";
            var test = "test";
            Logger.Log("", "{0} = {1} {2}", a, this._parameter, test);
            Logger.Log("", "{0,1: D} = ", new List<T>());
        }
    }

    internal class A
    {
    }
}