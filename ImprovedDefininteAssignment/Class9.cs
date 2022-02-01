// Sharp10 ImprovedDefiniteAssignment Class9.cs

using JetBrains.Annotations;

namespace ImprovedDefiniteAssignment33
{
    public class Class9
    {
        private void Test(S1? s1, S2? s2, [CanBeNull] WithStructField classWithStructField)
        {
            if (s1 == s2)
            {
                
            }

            if (classWithStructField!?.S1?.M1(null) == s2)
            {
                Console.WriteLine();
            }
        }
    }

    public class WithStructField
    {
        public S1? S1;
        public S2? S2;
    }

    public struct S1
    {
        public S1 M1(object obj) => this;
        public S2 M2(object obj) => new S2();

        //public static implicit operator S1(S2 s1) => new S1();
    }
    public struct S2
    {
        public static implicit operator S2?(S1? s1) => new S2();
        public static bool operator ==(S2 s1, S2 s2) => false;

        public static bool operator !=(S2 s1, S2 s2) => !(s1 == s2);
    }
}