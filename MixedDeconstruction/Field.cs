using System;

namespace MixedDeconstruction
{
    public class Field
    {
        public Field(int field1, string field2)
        {
            this.field1 = field1;
            this.field2 = field2;

            (this.field1, this.field2) = (field1, field2);

            (field1, var name, field2, var renamed) = (this.field1, "", this.field2, 11);

            Console.WriteLine(renamed);
            Console.WriteLine(renamed);

            (field3, var newName) = (A(), String.Empty);
            //(field4, int t) = (null, 1);
        }

        private static A A()
        {
            return new A();
        }

        private static void Test()
        {
            (field3, var newName) = (A(), String.Empty);
        }

        public void Deconstruct(out int field1, out string field2)
        {
            field1 = this.field1;
            field2 = this.field2;
        }

        private int field1;
        string field2;
        private static A field3 = null;
        private const A field4 = null!;
    }

    internal class A
    {
    }

//#nullable enable
//    class TestClass
//    {
//        private const string field = null!;

//        private void Test()
//        {
//            (field, int t) = (null, 1);
//        }
//    }
}