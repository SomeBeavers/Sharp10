namespace Framework
{
    public class MixedDeconstruction_Framework
    {
        private void Test()
        {
            int y;
            int z;
            (int x, y, z) = (1, 2, 3);
            (y, string name) = (1, string.Empty);
        }
    }
}