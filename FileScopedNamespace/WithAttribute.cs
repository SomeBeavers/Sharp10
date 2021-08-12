using System;
using FileScopedNamespace;

[assembly: System1]

namespace FileScopedNamespace
{
    public class WithAttribute
    {
    }

    public class System1Attribute : Attribute
    {
    }
}