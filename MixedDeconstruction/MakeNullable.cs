namespace MixedDeconstruction
{
    public class MakeNullable
    {
        private void Test()
        {
            (string s, int t) = (null, 1);
            (string s2, int t11) = (s, 1);
        }
    }
}