namespace Sharp10
{
    public class MixedDeconstruction
    {
        private void Test()
        {
            int y;
            (int x, y) = (1, 2);

            (var t, var s) = (1, 2);
            
        }
    }
}