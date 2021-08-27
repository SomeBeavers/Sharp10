namespace GlobalUsings
{
    public class Usages
    {
        public void Test()
        {
            Write("Test");
            var list = new List<string>();
            list.FirstOrDefault();
            var result = Log(1);
            Console.WriteLine();

            Clear();
        }
    }
}