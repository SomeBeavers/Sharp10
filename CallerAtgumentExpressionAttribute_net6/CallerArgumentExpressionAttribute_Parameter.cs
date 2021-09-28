// Sharp10 CallerArgumentExpressionAttribute_net6 CallerArgumentExpressionAttribute_Parameter.cs
#nullable disable
namespace CallerArgumentExpressionAttribute_net6
{
    // ReSharper disable once InconsistentNaming
    public static class CallerArgumentExpressionAttribute_Parameter
    {
        public static void ExtensionMethod<T>(this T myT, T notMyT, 
            [CallerArgumentExpression(null)] string text = "")
        {
        }
    }
}