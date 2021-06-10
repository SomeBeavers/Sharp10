using System;

namespace Sharp10
{
    public class ConstantInterpolatedStrings : Class1Base
    {
        const string myWholeFilePath = $@"{myRootPath}/README.md"; 
        const string TitleHeader = "Title";
        const string CountHeader = "Count";
    }

    public class Class1Base
    {
        public const string myRootPath = "/src/to/my/root";

        private static void Test(string myNewParameter) { }

        public void M()
        {
            Test(myRootPath);
        }
    }

    public interface IConstantInterpolatedStrings 
    {
        public const string myRootPath = "/src/to/my/root";
        const string myWholeFilePath = $@"{myRootPath}/README.md"; 
        const string TitleHeader = "Title";
        const string CountHeader = "Count";
    }
}