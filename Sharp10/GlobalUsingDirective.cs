using System;

[assembly:System1]
namespace Sharp10
{
    public class GlobalUsingDirective
    {
        private void Test()
        {
            Console.WriteLine();
        }
    }
}


public class System1Attribute : Attribute
{
}