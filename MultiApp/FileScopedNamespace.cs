using System;

#if NET6_0
namespace MultiApp;
#endif
#if NET5_0
//namespace MultiApp21;
#endif

public class FileScopedNamespace
{
#if NET5_0
    private void Test()
    {
        Console.WriteLine();
    }
#endif
}