using System;
using System.Runtime.CompilerServices;

namespace CallerArgumentExpressionAttribute_net5
{
    public class Class1
    {
        private const string ParameterName = "condition";

        public static void Argument(bool condition, string message,
            [CallerArgumentExpression("")] string conditionExpression = null)
        {
            new ArgumentNullException("");
        }
    }
}