namespace MultiApp
{
    public class MixedDeconstruction
    {
        private void Test(int age)
        {
            (var name, age) = ("new name", 11);
        }
    }
}