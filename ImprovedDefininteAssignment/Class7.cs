// Sharp10 ImprovedDefiniteAssignment Class7.cs

using System;

namespace ImprovedDefiniteAssignment
{
    public class Class7
    {
        private void Test(bool? nullableBool)
        {
            if (nullableBool is (true or false) and var x)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(nullableBool ?? false);
            }
        }
        private void Test3(S1? nullableBool)
        {
            if (nullableBool is { } x)
            {
                Console.WriteLine(x);
            }
            else
            {
                //Console.WriteLine(x);
            }

            //if (nullableBool?.NullableBool is not null and var x2)
            //{
            //    Console.WriteLine(x2.ToString());
            //}

            if (nullableBool?.NullableBool is null and var c)
            {
                Console.WriteLine(c.ToString());
            }
        }

        private void Test4(InnerClass a, bool? b)
        {
            if (((a.NullableBool ? b : null) ?? true) is var x)
            {
                Console.WriteLine(x);
            }

            var t = a.NullableBool;
        }

        private void Test5(Dictionary<string, S1?> dict)
        {
            if ((bool?)dict.TryGetValue("", out var test) ?? false)
            {
                Console.WriteLine(test);
            }

        }

        private void Test2(InnerClass cl, S1? s1, S1? s2)
        {
            if (s1 == s2)
            {
                if (s1 != null) Console.WriteLine(s1.Value);
            }
            else
            {
                Console.WriteLine(s1 != s2);
            }

            if (s1 == null)
            {

            }
        }
    }

    internal class C
    {
    }

    internal class InnerClass
    {
        public bool NullableBool { get; set; }
    }

    struct S1
    {
        public override bool Equals(object? obj) => base.Equals(obj);
        public static bool operator ==(S1 s1, S1 s2) => true;

        public static bool operator !=(S1 s1, S1 s2) => !(s1 == s2);
        public bool? NullableBool { get; set; }
    }
}