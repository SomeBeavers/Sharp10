using System;

namespace MixedDeconstruction
{
    public class LocalVariables
    {
        private void LocalVariables1(B a)
        {
            var innerClass = new InnerClass();

            (innerClass, var name) = a;

            (name, innerClass, var count, bool b) = ("newName", null, 1, false);

            Test(name, innerClass, count);

            (int Age, name) = (1, name + "_1");
            (innerClass, string newName) = (null, string.Empty);
        }

        private void LocalVariables2()
        {
            string declaredLocalVariable = string.Empty;
            (int t, declaredLocalVariable) = (1, "");
        }

        private void Test(string name, InnerClass innerClass, int count)
        {
            throw new System.NotImplementedException();
        }

        class InnerClass
        {
        }

        class B
        {
            public void Deconstruct(out InnerClass innerClass, out string name)
            {
                innerClass = this.innerClass;
                name = this.name;
            }

            private InnerClass innerClass;
            private string name;
        }
    }
}