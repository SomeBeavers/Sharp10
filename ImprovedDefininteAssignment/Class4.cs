// Sharp10 ImprovedDefiniteAssignment Class4.cs

namespace ImprovedDefiniteAssignment1
{
    public class Class4
    {
        private const bool FALSE = false;

        private void Test()
        {
            C c = new C();

            string x;

            S1? s1 = null;
            _ = s1?.M1(x = "a") ?? s1.Value.M2(x = "a");

            x.ToString(); // ok

        }
}


    public struct S1
    {
        public S1 M1(object obj) => this;
        public S2 M2(object obj) => new S2();
    }
    public struct S2
    {
        public static implicit operator S2(S1 s1) => new S2();
    }


    public class C
    {
        public bool M(out object obj)
        {
            obj = new object();
            return true;
        }
    }
}