namespace GlobalUsings_Clean.testf
{
    [My1]
    public class Class12 : Interface1
    {
        private void Test()
        {
            var generic = new Generic<string>();
            //1.Test();
            StaticClass.Test(1);
            new ReferenceMe();
        }

        public void Test2()
        {
            throw new NotImplementedException();
        }
    }
}