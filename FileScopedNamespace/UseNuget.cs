// Sharp10 FileScopedNamespace UseNuget.cs

namespace FileScopedNamespace; 

using Nuget;

public class UseNuget
{
    private void Test()
    {
        new ClassFromNuget();
        var constStringFromNuget = ClassFromNuget.ConstStringFromNuget;
    }
}