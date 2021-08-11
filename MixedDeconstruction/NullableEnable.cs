#nullable enable
namespace MixedDeconstruction
{
    public class NullableEnable
    {
        private static int _y = 1;

        private void Test()
        {
            (string x, _y) = (null, 2);

            //(int x, _y) = (1, 2);

            //(var t, var s) = (1, 2);
        }
    }
}