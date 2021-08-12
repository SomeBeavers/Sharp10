using System;

namespace MixedDeconstruction
{
#nullable disable
    public class MixBase
    {
        public ITestInterface BaseProp { get; set; }
    }

    public class Mix : MixBase
    {
        private string a;

        private void Test(params ClassWithDeconstuctor<int>[] parameters)
        {
            int Count(out string localVar1)
            {
                (var count, localVar1) = parameters[0];
                (string name, count) = ("", 1);
                return count;
            }

            var localVar = "";

            if (localVar != null)
            {
                if (parameters.Length == 1)
                {
                    var count = Count(out localVar);

                    Method(count, localVar);
                    (count, localVar) = parameters[0];

                    Method(count, localVar);

                    //(parameters[0].Name, int t, parameters[0].GenericProperty) = ("", 1, 2);
                    (var t, ClassWithDeconstuctor<int>.GenericField) = (1, 2);

                    (a, string s, var interface1) = (null, null, BaseProp);
                }
            }
        }

        private void Method(int count, string localVar)
        {
            throw new NotImplementedException();
        }
    }

    public interface ITestInterface
    {
    }
}