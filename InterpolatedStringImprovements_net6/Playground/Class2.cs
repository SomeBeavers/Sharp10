// Sharp10 InterpolatedStringImprovements_net6 Class2.cs

using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace InterpolatedStringImprovements_net6.Playground
{
    [InterpolatedStringHandler]
    public class Class2_Handler
    {
        public Class2_Handler(int t, int t1, string loggerName = "")
        {
            loggerName = null;
        }
        public Class2_Handler(int t, int t1, Class2_Logger logger, string loggerName)
        {
            loggerName = null;
        }

        public void AppendFormatted(string s)
        {
        }

        public void AppendLiteral(string s)
        {
        }
    }

    //class Class2Handler : Class2_Handler
    //{
    //    public Class2Handler(int t, int t1) : base(t, t1, "")
    //    {
    //    }
    //}

    public class Class2_Logger
    {
        //public static void Log(DefaultInterpolatedStringHandler handler)
        //{
        //}

        public Class2_Logger([InterpolatedStringHandlerArgument()] Class2_Handler handler)
        {
        }

        public static void Log([InterpolatedStringHandlerArgument("name")] Class2_Handler handler, string name = "")
        {
            name = null;
        }
        public void Log(string name, [InterpolatedStringHandlerArgument("", "name")]Class2_Handler handler)
        {
            name = null;
        }

        public static void Log(string name, string s)
        {
        }
    }

    public class Class2
    {
        private string field;

        public Class2()
        {
            field = "";
        }

        private async void Test(InnerClass2 test)
        {
            Class2_Logger.Log(name: this.field, handler: $"{await MethodAsync()} test");
            Class2_Logger.Log(name: this.field, handler: $"{test.ToString()} test");
            Class2_Logger.Log(name: this.field, s: $"{"await MethodAsync()"}");
            //Class2_Logger.Log(new Class2Handler(1,2));

            new Class2_Logger($"").Log("", $"test");
        }

        private async Task<string> MethodAsync()
        {
            throw new System.NotImplementedException();
        }
    }

    internal class InnerClass2
    {
    }
}