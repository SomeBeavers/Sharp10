using System;
using System.Diagnostics;

namespace Sharp10
{
    public class ConstantInterpolatedStrings : Class1Base
    {
        const string myWholeFilePath = $@"{Lib.Lib.ConstStringFromLib}/README.md";
        const string TitleHeader = "Title";
        const string CountHeader = "Count";
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
    }

    [Obsolete($"Ooh, don't use me. Instead, use {nameof(IConstantInterpolatedStrings)}.")]
    public class UseAttribute<T>
    {
        private const string Name = $"{nameof(UseAttribute<string>)} : class name";
        private const string Name2 = $"{Name} : class name";
    }
}