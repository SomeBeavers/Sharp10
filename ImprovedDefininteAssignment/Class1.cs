using System.Diagnostics.CodeAnalysis;

namespace ImprovedDefiniteAssignment
{
#nullable disable
    public class Class1
    {
        private void Test()
        {
            var c = new C();
            if (c != null && c.M(out var obj0)) obj0.ToString(); // ok

            if ((c != null && c.M(out object obj1)) == true)
            {
                obj1.ToString(); // undesired error
            }

            if ((c != null && c.M(out object obj2)) is true)
            {
                obj2.ToString(); // undesired error
            }

        }

        public class C
        {
            public bool M(out object obj)
            {
                obj = new object();
                return true;
            }
        }



        public static void Method1(object obj)
        {
            if (obj is not List<int> list)
            {
                InvalidOperation();
            }

            Console.WriteLine(list != null ? list.Count : (int?)null); // Works

            void InvalidOperation()
            {
                throw new InvalidOperationException();
            }
        }


        public void Foo(string m1, string m2)
        {
            if ((m1 == null) && ((m1 != null) || (m2 != null)))
            {
                // If m1 == null the above becomes
                // TRUE && (FALSE || m2!=null) 
                // which simplifies to 
                // TRUE && (m2!=null)
                // So this block should only execute if m1 == null and m2 != null

                NeedsNonNull(m2); // CS8604 that should not be flagged
            }
        }

        public void NeedsNonNull(string m)
        {
            // do stuff...
        }

        static void MethodC()
        {
            bool booleanVal = true;

            string b;
            if (booleanVal)
            {
                b = "has value";
            }
            if (booleanVal)
            {
               // Console.WriteLine(b); // Error CS0165 - b is considered unassigned
            }
        }

    }
}