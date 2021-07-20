using System;
using System.Diagnostics;

namespace Sharp10
{
    public class ConstantInterpolatedStrings : Class1Base
    {
        public const string myWholeFilePath = $@"{Lib.Lib.ConstStringFromLib}/README.md";
        const string TitleHeader = "Title";
        const string CountHeader = "Count";

        public void Test()
        {
            var s = myWholeFilePath;
        }
    }

    [DebuggerDisplay($"{{{nameof(Class1Base)}}}")]
    public class Class1Base
    {
        public const string myRootPath = "/src/to/my/root";

        private static void Test(string myNewParameter) { }

        public void M()
        {
            const int s = 1;
            //const string const_var = $"{s}";
            Test(myRootPath);
        }
    }

    public interface IConstantInterpolatedStrings 
    {
        public const string myRootPath = "/src/to/my/root";
        const string myWholeFilePath = $@"{myRootPath}/README.md"; 
        const string TitleHeader = "Title";
        const string CountHeader = "Count";

        const string MyConst = $"test: {TitleHeader} " +
                               $"" +
                               $"" +
                               $"" +
                               $"{CountHeader} " +
                               $"new string";

    }

    [Obsolete($"Ooh, don't use me. Instead, use {nameof(IConstantInterpolatedStrings)}.")]
    public class UseAttribute<T>
    {




        string json = $"{{\r\n    \"glossary\": {{\r\n        \"title\": " +
                            $"\"example glossary\",\r\n\t\t\"GlossDiv\": {{\r\n            \"title\": \"S\",\r\n\t\t\t\"GlossList\": {{\r\n                \"GlossEntry\": {{\r\n                    \"ID\": \"SGML\",\r\n\t\t\t\t\t\"SortAs\": \"SGML\",\r\n\t\t\t\t\t\"GlossTerm\": \"Standard Generalized Markup Language\",\r\n\t\t\t\t\t\"Acronym\": \"SGML\",\r\n\t\t\t\t\t\"Abbrev\": \"ISO 8879:1986\",\r\n\t\t\t\t\t\"GlossDef\": {{\r\n                        \"para\": \"A meta-markup language, used to create markup languages such as DocBook.\",\r\n\t\t\t\t\t\t\"GlossSeeAlso\": [\"GML\", \"XML\"]\r\n                    }},\r\n\t\t\t\t\t\"GlossSee\": \"markup\"\r\n                }}\r\n            }}\r\n        }}\r\n    }}\r\n}}";

        private const string Name = $"{nameof(UseAttribute<string>)} : class name";
        private const string Name2 = $"{Name} : class name";

        private void Test()
        {
            string MyConst = $"test new";
        }
    }

    class MyClass5
    {
        private const string MyConst2 = "a";

        private const string MyConst = $"test/*caret*/ new {MyConst2}";
        private string MyNotConst = $"test/*caret*/ new {MyConst2}";
    }
}