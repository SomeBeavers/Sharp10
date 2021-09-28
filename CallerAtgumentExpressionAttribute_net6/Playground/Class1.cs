// Sharp10 CallerArgumentExpressionAttribute_net6 Class1.cs

using System.Runtime.InteropServices;

namespace CallerArgumentExpressionAttribute_net6.Playground
{
    public class Class1
    {
        const string s5 = nameof(s5);
        //delegate void D(
        //    [CallerArgumentExpression(s5)][Optional][DefaultParameterValue("default")] ref string s1, string s2, string s3, string s4, string s5);
    }

    internal static class Preconditions
    {
        internal static T CheckNotNull<T>(T value, [CallerArgumentExpression("value")] string paramName = "") =>
            value ?? throw new ArgumentNullException(paramName);
        internal static void CheckRange(int value, int minInclusive, int maxInclusive,
            [CallerArgumentExpression("value")] string paramName = "")
        {
            if (value < minInclusive || value > maxInclusive)
            {
                throw new ArgumentOutOfRangeException(paramName, $"Value must be in the range [{minInclusive}-{maxInclusive}]");
            }
        }
    }


    class Base
    {
        const string p = nameof(p);
        public Base(int p = 0, [CallerArgumentExpression(p)] string arg = " < default - arg - base > ")
        {
            Console.WriteLine("Base class: " + arg);
        }
    }
    class Derived1 : Base
    {
        const string ppp = nameof(ppp);
        public Derived1(int ppp, [CallerArgumentExpression("ppp")] string arg = " < default - arg - derived1 > ")
            : base(ppp)
        {
            Console.WriteLine("Derived1 class: " + arg);
        }
    }


    partial class A
    {
        //partial void OnSomethingHappened(string s);
        partial void OnSomethingHappened(String s, string text = "");
    }

    partial class A
    {
        partial void OnSomethingHappened(String s1, [CallerArgumentExpression("s1")]string text1)
        {
            Console.WriteLine("Something happened: {0}", s1);
        }
    }
}