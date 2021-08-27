namespace GlobalUsings_Multi_Console
{
    class Program
    {
        static void Main(string[] args)
        {
#if NET5_0
                new ReferenceMe();
            Console.WriteLine("Hello World!");        
#endif

#if NET6_0
            new UseMe();
#endif
        }
    }
}
