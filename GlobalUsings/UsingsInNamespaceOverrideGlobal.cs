// Sharp10 GlobalUsings UsingsInNamespaceOverrideGlobal.cs

namespace GlobalUsings
{
    using System;
    using MyAlias = System;

    public class UsingsInNamespaceOverrideGlobal
    {
        private void Test()
        {
            MyAlias.Console.WriteLine();
            new MyClass();
        }
    }
}
