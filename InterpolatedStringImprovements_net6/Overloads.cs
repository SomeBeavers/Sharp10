// Sharp10 InterpolatedStringImprovements_net6 Overloads.cs

using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MyNamespace
{
    public partial class Overloads
    {
        //public partial bool AppendFormatted(string s);
    }

    [InterpolatedStringHandler]
    public partial class Overloads
    {
        #region C-ors
        public Overloads(int t, int t1)
        {
        }
        public Overloads(int t, int t1, out bool b)
        {
            Console.WriteLine("Overloads(int t, int t1, out bool b)");
            b = false;
        }

        #endregion

        #region AppendFormatted methods

        public bool AppendFormatted(string s)
        {
            return false;
        }

        public bool AppendFormatted<T>(T genericParameter) where T : class
        {
            return false;
        }
        public bool AppendFormatted<T>(T genericParameter, string format) where T : struct
        {
            return false;
        }
        public bool AppendFormatted<T>(InnerGeneric<T> genericParameter)
        {
            return false;
        }

        public bool AppendFormatted(IA1 value, int alignment)
        {
            Console.WriteLine("AppendFormatted(IA1 value, int alignment)");
            return false;
        }

        public bool AppendFormatted(IB1 value, int alignment)
        {
            Console.WriteLine("AppendFormatted(IB1 value, int alignment)");
            return false;
        }

        public bool AppendFormatted(string? value, int alignment = 0, string? format = null)
        {
            return false;
        }

        public bool AppendFormatted(object? value, int alignment = 0, string? format = null)
        {
            return false;
        }

        public bool AppendFormatted(ReadOnlySpan<string> value)
        {
            return false;
        }
        public bool AppendFormatted(SuperClass c, int alignment = 0, string? format = null)
        {
            return false;
        }
        public bool AppendFormatted(Derived1 c, int alignment = 0, string? format = null)
        {
            return false;
        }

        #endregion
        #region AppendLiteral methods

        public bool AppendLiteral(string value)
        {
            return false;
        }

        #endregion
        /*
                

        public void AppendFormatted<T>(T value);
        public void AppendFormatted<T>(T value, string? format);
        public void AppendFormatted<T>(T value, int alignment);
        public void AppendFormatted<T>(T value, int alignment, string? format);

        public void AppendFormatted(ReadOnlySpan<char> value);
        public void AppendFormatted(ReadOnlySpan<char> value, int alignment = 0, string? format = null);

        public void AppendFormatted(string? value);
        public void AppendFormatted(string? value, int alignment = 0, string? format = null);

        public void AppendFormatted(object? value, int alignment = 0, string? format = null);

         */
    }

    public class Logger2
    {
        public void Log(Overloads handler)
        {
            Console.WriteLine("Log(Overloads handler)");
        }
        public void LogRefStruct(RefStructHandler refStructHandler)
        {
            Console.WriteLine("Log(Overloads handler)");
        }

        public void Log(string s)
        {
            Console.WriteLine("public void Log(string s)");
        }

        public void Log(string t,[InterpolatedStringHandlerArgument("t")]Overloads2<string> handler)
        {
        }
    }

    [InterpolatedStringHandler]
    public ref struct RefStructHandler
    {
        public RefStructHandler(int t , int t2)
        {
        }

        public void AppendFormatted(string s)
        {
        }
    }

    [InterpolatedStringHandler]
    public class Overloads2<T>
    {
        public Overloads2(int t, int t2, T parameter)
        {
        }
    }

    public class Use5
    {
        private static string StaticField = "";
        private string InstanceField;

        public delegate int PerformCalculation(int x, int y);

        private async Task ChooseLogOverload(string stringParameter)
        {
            const string variable = "test";
            const string constVariable = variable + "_";

            PerformCalculation x = (i, i1) => { return 1; };

            new Logger2().Log($"");
            new Logger2().Log($"{"test"}");
            new Logger2().Log($"{'c'}");
            new Logger2().Log($"{1}");
            new Logger2().Log($"{constVariable}");
            new Logger2().Log($"{StaticField}");
            new Logger2().Log($"{StaticMethod()}");
            new Logger2().Log($"{InstanceMethod(), 1 :T}");
            //new Logger2().Log($"{() => constVariable}");
            new Logger2().Log($"{x}");
            new Logger2().Log($"{await MethodAsync()}");

            var localvariable = "localVariable";
            new Logger2().Log($"{localvariable}");
            new Logger2().Log($"{ConstField}");
            new Logger2().Log($"{this.InstanceField.Length, 1: S} test");
            
            
            //new Logger2().LogRefStruct($"{await MethodAsync()}");


            string s = $"";
            new Logger2().Log(s);
            string test = $"{"test"}";
            new Logger2().Log(test);
            new Logger2().Log($"{'c'}");
            Overloads overloads = $"{1,1}";
            new Logger2().Log(overloads);

            new Logger2().Log(string.Format("{0}", 1));

            new Logger2().Log($"{s}" + $"");
            new Logger2().Log(new A().ToString());

            //new Logger2().Log($"{'c'}" as Overloads);
        }

        private const string ConstField = "VALUE";

        private async Task<string> MethodAsync()
        {
            throw new NotImplementedException();
        }

        private object InstanceMethod()
        {
            throw new NotImplementedException();
        }

        private static string StaticMethod()
        {
            throw new NotImplementedException();
        }

        private void Test(Logger2 logger, string stringParameter)
        {
            new Logger2().Log($"{stringParameter} literal");

            InnerStruct innerStruct = new InnerStruct();
            new Logger2().Log($"{innerStruct:Test} literal");

            InnerGeneric<string> innerGeneric = new InnerGeneric<string>();
            new Logger2().Log($"{innerGeneric} literal");

            var a1 = new A1();
            // ambig
            //new Logger2().Log($"{a1, 1} literal");

            string s = "";
            new Logger2().Log($"{(object)s, 1 : test} literal");

            ReadOnlySpan<string> span = s.Split(',');
            string[] strings = s.Split(',');

            new Logger2().Log($"{span} literal");
            new Logger2().Log($"{s.Split(',')} literal");

            new Logger2().Log("", $"");

            SuperClass sc = new SuperClass();

            new Logger2().Log($"{sc, 1}");
            new Logger2().Log($"{sc}");

            if (sc is Derived1)
            {
                new Logger2().Log($"{sc as Derived1, 1}");
            }
        }



        struct InnerStruct:IFormattable
        {
            public string ToString(string? format, IFormatProvider? formatProvider) => throw new NotImplementedException();
        }
    }

    public class InnerGeneric<T>
    {
    }

    public interface IA1
    {

    }

    public interface IB1
    {

    }

    public class SuperClass
    {
    }

    public class Derived1 : SuperClass
    {
    }
    class Derived2 : SuperClass
    {
    }

    public class A1 : IA1, IB1
    {
        public override string ToString() => $"test" + base.ToString();
    }
}