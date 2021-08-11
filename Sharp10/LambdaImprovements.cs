using System;

namespace Sharp10
{
    public class LambdaImprovements
    {
        [A]
        private void Test1(out Func<string, string> f)
        {
            //f = [A]() => { return ""; }; 
            f = ([A] x)=> x; // [A] x
        }

        [A]
        private void Test2(out Func<string> f)
        {
            f = [A]() => { return ""; };
        }

        //[A]
        //private void Test3(out Func<int, int> f)
        //{
        //    f = int(int x) => x; // ok
        //    int t = f(1);
        //}
    }

    internal class AAttribute : Attribute
    {
    }
}