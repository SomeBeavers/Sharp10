// Sharp10 GlobalUsings MoveStaticMethodFromHere.cs

namespace GlobalUsings.Refactorings
{
    public class MoveStaticMethodFromHere
    {
        public static void StaticMethod1()
        {
            var first = new List<string>().First();
        }

        public static void MoveMe()
        {
            StaticMethod1();
        }
    }
}