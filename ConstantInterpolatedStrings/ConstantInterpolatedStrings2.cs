using System;
using Nuget;

namespace ConstantInterpolatedStrings
{
    public class ConstantInterpolatedStrings2
    {
        const string myRootPath = "/src/to/my/root";
        const string myWholeFilePath = $"{myRootPath}/README.md";
        const string myWholeFilePath2 = $@"{Lib.Lib.ConstStringFromLib}/README.md";
        const string myWholeFilePath3 = $@"{Lib.Lib.ConstStringFromLib}/test";
        private const string FromNuget = $"{ClassFromNuget.ConstStringFromNuget} - from nuget";
        private const string FromDll = $"{Dll.FromDll.ConstStringFromDll} - from dll";

        public int T = 1;
        private string notConst = "test";
        //private const string test = $"{notConst}";


        [Obsolete($"Ooh, don't use me. Instead, use {nameof(ConstantInterpolatedStrings2)}.")]
        private static void Test()
        {
            string s = $"{ClassFromNuget.ConstStringFromNuget} - from nuget";
            Console.WriteLine(myWholeFilePath);
            Console.WriteLine(FromNuget);
        }
    }

    class MyClass
    {
        const string myRootPath = "/src/to/my/root";
        const string MyConstString = $"{myRootPath}";

        private void Test()
        {
            string localString = $"{myRootPath}";
        }
    }
}