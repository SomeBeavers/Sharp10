using System;

namespace MixedDeconstruction
{
    public class Tuple
    {
        private void Test()
        {
            var (name, age) = GetTuple();

            // ((name, age), var name2, var (tuple1, tuple2)) = ((name: "", age: 1), ",", ("", 2));

            ((name, age), var name2, var (tuple1, tuple2)) = ((name: "", age: 1), ",", ("", 2));

            ((name, age), var name3, var (tuple11, tuple22)) = (("", 1), "", ("", 2));
            var s = tuple1;
        }

        private (string name, int age) GetTuple()
        {
            throw new NotImplementedException();
        }
    }
}