namespace FileScopedNamespace
{
    using System;

    public class FileScopedNamespace1
    {
        private void Test()
        {
            FileScopedNamespace1 fs = new FileScopedNamespace1();
            Console.WriteLine();
        }
    }
}