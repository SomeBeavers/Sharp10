using System;
using System.Runtime.CompilerServices;

namespace MyNamespace
{
    [InterpolatedStringHandler]
    public record R<T1>()
    {
        //public R(int t, int t2, out T handlerIsValid) : this()
        //{
        //    Console.WriteLine("handlerIsValid");
        //    handlerIsValid = default(T);
        //}

        //public R(int t, int t2, out bool handlerIsValid) : this()
        //{
        //    Console.WriteLine("handlerIsValid");
        //    handlerIsValid = false;
        //}
        //public R(int t, int t2, string extraParameter, out bool handlerIsValid) : this()
        //{
        //    Console.WriteLine("handlerIsValid");
        //    handlerIsValid = false;
        //}
        internal R(int t, int t2, out bool handlerIsValid) : this()
        {
            Console.WriteLine("handlerIsValid");
            handlerIsValid = false;
        }
        internal R(int t, int t2) : this()
        {
        }

        public void AppendLiteral(string s)
        {
        }
        public void AppendFormatted<T>(T value)
        {
            throw new NotImplementedException();
        }

        //public void AppendFormatted<T>(T value, string? format)
        //{
        //    throw new NotImplementedException();
        //}

        //public void AppendFormatted<T>(T value, int alignment)
        //{
        //    Console.WriteLine("AppendFormatted<T>(T value, int alignment)");
        //}

        public void AppendFormatted<T>(T value, int alignment, string? format)
        {
            throw new NotImplementedException();
        }

        public void AppendFormatted(ReadOnlySpan<char> value)
        {
            throw new NotImplementedException();
        }

        //public void AppendFormatted(ReadOnlySpan<char> value, int alignment = 0, string? format = null)
        //{
        //    throw new NotImplementedException();
        //}

        public void AppendFormatted(string? value)
        {
            throw new NotImplementedException();
        }

        public void AppendFormatted(string? value, int alignment = 0, string? format = null)
        {
            throw new NotImplementedException();
        }

        public void AppendFormatted(A value)
        {
            throw new NotImplementedException();
        }
        public void AppendFormatted(IA value, int alignment)
        {
            Console.WriteLine("AppendFormatted(IA value, int alignment)");
        }

        public void AppendFormatted(IB value, int alignment)
        {
            Console.WriteLine("AppendFormatted(IB value, int alignment)");
        }

        //public void AppendFormatted(object? value, int alignment = 0, string? format = null)
        //{
        //    throw new NotImplementedException();
        //}


        //public R(int t, int t2) : this()
        //{
        //}
    }

    [InterpolatedStringHandler]
    struct MyStruct
    {

    }

    public static class AttributeOnRecord
    {
        public static string Log(string extraParameter,
            [InterpolatedStringHandlerArgument()] R<string> handler)
        {
            handler.AppendFormatted((IA)new A(), 4);
            return null;
        }
    }

    public class R1
    {
    }

    class Use3
    {
        private void Test()
        {
            A variable = new();
            AttributeOnRecord.Log("",$"t{variable}");
            AttributeOnRecord.Log(extraParameter: "",handler: $"");

            ReadOnlySpan<char> span = "hi there";
            //AttributeOnRecord.Log(extraParameter: "",handler: $"{span, 4}");
            AttributeOnRecord.Log(extraParameter: "",handler: $"{span}");

            // TODO: uncomment

            //AttributeOnRecord.Log(extraParameter: "",handler: $"{new A(), 4}");
            //AttributeOnRecord.Log(extraParameter: "",handler: $"{span}");

            //AttributeOnRecord.Log(extraParameter: "", handler: $"{new Struct(),4}");
            //AttributeOnRecord.Log(extraParameter: "", handler: $"{span}");

            //char[] var_char = new[] { 'a', 'b' };

            //AttributeOnRecord.Log(extraParameter: "", handler: $"{var_char,4}");
            //AttributeOnRecord.Log(extraParameter: "", handler: $"{var_char}");
        }
    }

    public class A: IA, IB
    {
        public override string ToString() => $"test" + base.ToString();
    }

    public interface IA
    {
    }

    public interface IB
    {
    }

    public struct Struct
    {
    }
}