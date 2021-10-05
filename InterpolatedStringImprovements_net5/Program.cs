using System;
using System.Runtime.CompilerServices;

namespace InterpolatedStringImprovements_net5
{
    //[InterpolatedStringHandler]
    class Handler
    {
        
    }

    class Use7
    {

        private string? _field2 = "";

        public Use7()
        {
        }

        private void Test()
        {
            if (this._field2 != null)
            {
                string s = $"{this._field2}";
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
