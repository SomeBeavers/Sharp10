// Sharp10 FileScopedNamespace UseReferencedProject.cs

#region test

using System;
using Lib.Inner;

#endregion

namespace FileScopedNamespace;

public class UseReferencedProject
{
    private void Test()
    {
        //new Lib_FileScopedNamespace().Test1();
        new Lib_FileScopedNamespace();
        //new ClassToRemove();
    }
}
