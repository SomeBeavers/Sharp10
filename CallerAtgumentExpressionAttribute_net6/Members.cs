// Sharp10 CallerArgumentExpressionAttribute_net6 CallerArgumentExpressionAttribute_Members.cs

using System.Runtime.InteropServices;

namespace CallerArgumentExpressionAttribute_net6
{
    public class Members
    {

        private const string i = nameof(i);

        public int this[int i, [CallerArgumentExpression(i)] string s = " < default - arg > "]
        {
            get => i;
            set => Console.WriteLine($"{i}, {s}");
        }

        delegate void D(string s1, 
            [CallerArgumentExpression("s1")]
            [Optional]
            [DefaultParameterValue("default")]
             string s2);

        public delegate void PerformCalculation(int x, int y, 
            [CallerArgumentExpression("x")]string s = "");

        public Members(string Property, 
            [CallerArgumentExpression("Property")] string text = "")
        {
            throw new ArgumentOutOfRangeException("Property");
            throw new ArgumentOutOfRangeException("Property");
        }

        static void Log2(int p, [CallerArgumentExpression("p")][CallerMemberName] string arg = " < default > ")
        {
            Console.WriteLine(arg);
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