// Sharp10 MultiApp FileScopedNamespace2.cs

using System;
using Test1;

namespace MultiApp.FileScopedNamespaces.inner;

public class FileScopedNamespace2
{
    private void Test()
    {
        Console.WriteLine();
        new FileScopedNamespace3();
    }
}