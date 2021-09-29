// Sharp10 CallerArgumentExpressionAttribute_net6 Class2.cs

global using System;

namespace CallerArgumentExpressionAttribute_net6.Playground
{
    internal class Class2
    {
        private const string i = nameof(i);

        public int this[int i, [CallerArgumentExpression(i)] string s = " < default - arg > "]
        {
            get => i;
            set => Console.WriteLine($"{i}, {s}");
        }
    }
}