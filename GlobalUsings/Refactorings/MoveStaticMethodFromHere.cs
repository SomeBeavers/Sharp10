// Sharp10 GlobalUsings MoveStaticMethodFromHere.cs

namespace GlobalUsings.Refactorings
{
    public class MoveStaticMethodFromHere
    {
        public static void StaticMethod1()
        {
        }

        public static void MoveMe()
        {
            StaticMethod1();
        }
    }
}