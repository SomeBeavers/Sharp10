namespace Sharp10
{
    #nullable enable
    public class MixedDeconstruction
    {
        private static int _y = 1;

        private void Test()
        {
            (var x, _y) = (1, 2);

            var (t, _y1) = (1, 2);
        }
    }
}