// used using
global using System.Runtime.CompilerServices;

// unused using here but used in another file
global using System.Runtime.Remoting;

// unused
global using System.Runtime.InteropServices;


namespace GlobalUsings.Refactorings
{
    public class MoveToAnotherFileWithGlobalUsings
    {
        private void Test()
        {
            YieldAwaitable a;
            ObjectHandle b;
        }
    }
}