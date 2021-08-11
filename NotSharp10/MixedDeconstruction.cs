using System;

namespace NotSharp10
{
    public class MixedDeconstruction
    {
        private void Test()
        {
            int y;
            int x;
            int z;
            (x, y, z) = (1, 2, 3);

            (string name, int count) = ("newName", 1);

            Console.WriteLine(count);
        }
    }

#nullable disable
    public class QF<T>
    {
        private void Test()
        {
 

            (T localT, string newLoc/*caret*/) = (default, "1");
        }
    }
}