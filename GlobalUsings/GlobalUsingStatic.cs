global using System;
global using static System.Math;
using System.Collections.Specialized;

namespace GlobalUsings
{
    
    public class GlobalUsingStatic
    {
        private void Test()
        {
            new ListDictionary();
           // new ListBindableAttribute();
            var pi = PI;
            var s = Tau;
        }
    }
}