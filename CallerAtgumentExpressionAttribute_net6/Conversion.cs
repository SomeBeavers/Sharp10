// Sharp10 CallerArgumentExpressionAttribute_net6 Conversion.cs

namespace CallerArgumentExpressionAttribute_net6
{
    public class Conversion
    {
        private void Test(int t, [CallerArgumentExpression("t")]object text = null)
        {
        }

        private void Test2()
        {
        }
    }

    class Json
    {
        private Json(string json)
        {
            //logic to parse string into object
        }

        public static implicit operator Json(string input)
        {
            ReadOnlySpan<char> c = string.Empty;
            string c1 = string.Empty;
            return new Json(input);
        }
        public static implicit operator string(Json input)
        {
            return "";
        }

        public override string ToString() => base.ToString();
    }
}