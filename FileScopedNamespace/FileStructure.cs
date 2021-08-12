// Sharp10 FileScopedNamespace FileStructure.cs

// TODO: test namespace
namespace FileScopedNamespace;

public class FileStructure
{
    public string Name { get; set; }

    private static void MoveMe()
    {
    }

    public void Test()
    {
        MoveMe();
    }
}

record MyRec(string Name, int Age);