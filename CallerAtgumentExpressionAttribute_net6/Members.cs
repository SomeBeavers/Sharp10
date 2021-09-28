// Sharp10 CallerArgumentExpressionAttribute_net6 CallerArgumentExpressionAttribute_Members.cs

namespace CallerArgumentExpressionAttribute_net6
{
    public class Members
    {
        public delegate void PerformCalculation(int x, int y, 
            [CallerArgumentExpression("x")]string s = "");

        public Members(string Property, 
            [CallerArgumentExpression("Property")] string text = "")
        {
            throw new ArgumentOutOfRangeException("Property");
            throw new ArgumentOutOfRangeException("Property");
        }

        public Members()
        {
        }

        private void Lambda()
        {
            //new List<string>().Where(([CallerArgumentExpression("a")] x) => x == null);
            
            new List<string>().Where(([My("a")] x) => x == null);
        }

        public async Task MethodAsync(InnerClass innerClass, CancellationToken token,
            [CallerArgumentExpression("token")]string token_description = "default",
            [CallerArgumentExpression("innerClass")]string innerClassDescription = "default"
            )
        {
            await Task.Delay(100, token);
        }

        public class InnerClass
        {

            private async Task Test()
            {
               await new Members().MethodAsync(this, CancellationToken.None);
            }
        }
    }
}