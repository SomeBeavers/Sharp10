// Sharp10 GlobalUsings AliasInNamespace.cs

namespace GlobalUsings
{
    using NewAlias = MyAlias;
    using MyAlias;
    public class AliasInNamespace
    {
        private void Test()
        {
            var func = NewAlias.JsonConvert.DefaultSettings;
        }
    }
}