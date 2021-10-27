// Sharp10 InterpolatedStringImprovements_net6 Refactorings.cs

using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace InterpolatedStringImprovements_net6
{
    [InterpolatedStringHandler]
    public struct Refactorings_Handler
    {
        public Refactorings_Handler(int t, int t1)
        {
        }

        public void AppendFormatted(int t)
        {
        }
        public void AppendFormatted(string t)
        {
        }

        public void AppendLiteral(string s)
        {
        }
    }

    public static class RefactoringsLogger
    {
        public static void Log(this string s, Refactorings_Handler handler)
        {
        }

        [StringFormatMethod("handler")]
        public static void Log(this string s, string handler, params object[] a)
        {
        }
        [StringFormatMethod("handler")]
        public static void Log(string handler, params object[] a)
        {
        }

        public static void Log(Refactorings_Handler handler)
        {
        }

        //public static void Log(this string s, string s2)
        //{
        //}
    }

    class Use7
    {
        public Refactorings_Handler Property { get; set; } = $"test";

        private string field1;
        private string? _field2 = "";

        public Use7()
        {
            field1 = $"{this._field2}";
        }

        private void Test(InnerClass parameter)
        {
            Refactorings_Handler local = $"";
            var localString = "";
            var localInt = 1;

            //"".Log($"{this._field2}");
 
            "".Log($"{Method()}");
            "".Log("{0}", Method());
            RefactoringsLogger.Log($"{Method()}");



            "".Log($"{field1.ToString()}");
            "".Log(Method2());
            "".Log(Property);
            //new Refactorings_Handler(1,2).AppendFormatted();
        }

        private Refactorings_Handler Method2()
        {
            throw new System.NotImplementedException();
        }

        private int Method()
        {
            throw new System.NotImplementedException();
        }
    }

    internal class InnerClass
    {
    }
}