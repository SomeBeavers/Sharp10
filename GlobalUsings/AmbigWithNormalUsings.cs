using System;
//using MyAlias = System;

namespace GlobalUsings
{
    public class AmbigWithNormalUsings
    {
        private void Test()
        {
            //MyAlias.Console.WriteLine();
            new MyClass();
        }
    }
}