using System.Diagnostics;

#nullable disable
namespace CallerArgumentExpressionAttribute_net6
{
    // ReSharper disable once InconsistentNaming
    public static class Parameter
    {
        private const string ParameterName = "this";

        public static void ExtensionMethod<T>(this T @this, T notMyT, 
            [CallerArgumentExpression(ParameterName /*+ "_"*/)] string text = "")
        {
            Console.WriteLine($"CallerArgumentExpression: {text}");
        }
    }

    public class CallerArgumentExpressionAttribute_Parameter2
    {
        //private void Test<T>(bool parameterName, string s,
        //    string s2,
        //    [CallerArgumentExpressionAttribute("123")] string t = default)
        //{
        //    Console.WriteLine($"CallerArgumentExpression: {t}");
        //}

        private void Test2<T>(bool parameterName, string s,
            string s2,
            [CallerArgumentExpressionAttribute("t2")] string t = default,
            [CallerArgumentExpressionAttribute("t")] string t2 = default)
        {
            Console.WriteLine($"CallerArgumentExpression: {t}");
        }

        //public void Test3([CallerArgumentExpression("1")]string optional = "")
        //{
        //}

        //public void CaseSensitive(
        //    /*comment*/ int /*aaaa*/t,
        //    [CallerArgumentExpression("T")]
        //    string test = ""
        //    )
        //{
        //}

        public void Comments1(
            /*comment*/ int /*aaaa*/t/*bbb*/,
            [CallerArgumentExpression("t")]
            string test = ""
        )
        {
        }
    }

    public class Use_CallerArgumentExpressionAttribute_Parameter
    {
        private void Test()
        {
            //Debug.Assert(false == true);
            "".ExtensionMethod("", "false == true");
        }
    }
}