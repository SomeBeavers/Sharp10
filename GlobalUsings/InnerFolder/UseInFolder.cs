namespace GlobalUsings_AnotherNamespace.InnerFolder
{
    public record UseInFolder()
    {
        private void Test()
        {
            WriteLine(new a().First());
            var dateParseHandling = typeof(MyAlias.DateParseHandling);
            new ReferenceMe().Method();
        }
    }
}