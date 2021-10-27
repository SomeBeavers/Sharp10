// Sharp10 InterpolatedStringImprovements_net6 SeveralHandlers.cs

using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace MyNamespace
{
    [InterpolatedStringHandler]
    struct Handler1
    {
        public Handler1(int literalLength, int formattedCount)
        {
        }

        public void AppendFormatted(string s)
        {
        }
    }
  
    

    [InterpolatedStringHandler]
    struct Handler2
    {
        public Handler2(int literalLength, int formattedCount)
        {
        }

        public void AppendFormatted(string s)
        {
        }
        
    }

    class C
    {
        public void M(Handler1 handler)
        {
        }
        [StringFormatMethod("handler")]
        public void M(string handler, params object[] a)
        {
        }

        public void M(Handler2 handler)
        {
        }
    }

    public class SeveralHandlers
    {
        private void Test(C c)
        {
            c.M(@"{0}", X);
        }

        public string X { get; set; }
    }
}