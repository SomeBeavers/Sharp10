//global using System.Runtime.CompilerServices;

#nullable disable
namespace CallerArgumentExpressionAttribute_net6
{
    public class CallerArgumentExpressionAttribute1
    {
        public static void Argument(bool condition, string message,
            [CallerArgumentExpression("condition")]
            string conditionExpression = null)
        {
            new ArgumentNullException("");
        }

        //[CallerArgumentExpression("")]
        public void Test1(
            string parameter,
            [CallerArgumentExpressionAttribute("parameter")] string s = "")
        {
        }
    }

    public class MyAttribute : Attribute
    {
        public MyAttribute(string empty)
        {
            throw new NotImplementedException();
        }
    }
}