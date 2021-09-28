// Sharp10 CallerArgumentExpressionAttribute_net6 CorInAttribute.cs

namespace CallerArgumentExpressionAttribute_net6
{
    public class CorInAttribute
    {
        public class MyAttribute : Attribute
        {
            public MyAttribute(string s, 
                [CallerArgumentExpression("s")] string x = "") { }
        }

        [My("Hello")]
        public class Program { }
    }

}