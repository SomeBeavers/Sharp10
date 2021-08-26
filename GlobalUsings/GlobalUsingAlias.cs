// Sharp10 GlobalUsings GlobalUsingAlias.cs

global using MyAlias = Newtonsoft.Json;

namespace GlobalUsings
{
    public class GlobalUsingAlias
    {
        private void Test()
        {
            var jsonConvert = MyAlias.JsonConvert.DefaultSettings;
            var jsonConvert2 = MyAlias.JsonConvert.DefaultSettings;
            var jsonConvert3 = MyAlias.JsonConvert.DefaultSettings;
        }
    }
}