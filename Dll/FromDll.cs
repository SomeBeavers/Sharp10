using System;

namespace Dll
{
    public class FromDll
    {
        public const int i = 1;
        public const string myString = "myString";
        public const string ConstStringFromDll = $"{myString} {nameof(i)} - string";
    }
}
