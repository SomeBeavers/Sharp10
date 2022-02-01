// Sharp10 ImprovedDefiniteAssignment Class6.cs

using JetBrains.Annotations;

using System.Diagnostics.CodeAnalysis;

namespace ImprovedDefiniteAssignment11
{
    public class Class6
    {
        //private void Test(S1? parameter, bool parameter2, bool parameter3, bool? nullableBoolParameter = true)
        //{
        //    S1? s1 = new S1();
        //    S2? s2 = new S2();

        //    var s = (s1 ?? s2).ToString();

        //    if (parameter?.B is null and var x)
        //    {
        //        Console.WriteLine(x.HasValue);
        //    }
        //}

        private void Test2(S1? parameter)
        {
            bool length = parameter?.C!?.Prop ?? false;

            if (!length)
            {
                return;
            }
        }

        private bool BoolParameter = false;
    }



    public struct S1
    {
        public S1 M1(object obj) => this;
        public S2 M2(object obj) => new S2();
        public bool? B { get; set; }
        public C C { get; set; }
    }

    public class C
    {
        public bool? Prop { get; set; }

        private bool IsPandigital(params int[] nums)
        {
            int digits = 0;
            for (int i = 0; i < nums.Length; i++)
            for (; nums[i] > 0; nums[i] /= 10)
                if (nums[i] % 10 == 0 || digits == (digits |= 1 << (nums[i] % 10 - 1))) // This line might be the cause of this issue
                    return false;
            return digits == 0b111111111; // This line shows the issue
}
        public struct Test
        {
            [System.Diagnostics.CodeAnalysis.NotNull] private object x;
            public bool IsValid => x != null; // warning

            public Test(object x)
            {
                this.x = x;
            }
        }

    }

    public struct S2
    {
        public static implicit operator S2(S1 s1) => new S2();
    }
}