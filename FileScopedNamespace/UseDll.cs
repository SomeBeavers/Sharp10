// Sharp10 FileScopedNamespace UseDll.cs

namespace FileScopedNamespace;

using Dll;

public class UseDll
{
    private void Test()
    {
        new FromDll();
        var constStringFromDll = FromDll.ConstStringFromDll;
    }
}