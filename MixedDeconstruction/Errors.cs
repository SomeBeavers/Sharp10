namespace MixedDeconstruction
{
    public class Errors
    {
        private string s;
        private int _y;

        private void Test()
        {
            (var x, _y) = (1, 2);
            (x, string s) = (1, "2");
        }
    }
}