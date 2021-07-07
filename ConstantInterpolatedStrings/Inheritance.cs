using System;

namespace ConstantInterpolatedStrings
{
    public class InheritanceBase
    {
        protected const string BaseName = nameof(InheritanceBase);
    }

    public class Inheritance : InheritanceBase
    {
        public const string DerivedName = $@"{BaseName} - name";
        private const string TitleHeader = "Some";
        private const string CountHeader = "Beavers";
        //const string TableHeader = $"{TitleHeader,-50}|{CountHeader,10}";
        private const string myRootPath = "{0}README.md";
        const string myFilePath = $@"{myRootPath}README.md";

        public Inheritance():base()
        {
            const string baseName = BaseName + "test";
        }
    }

    class MyClass4
    {
        private const string Name = nameof(MyClass4);
        //private const string WithFormatting = $@"{DateTime.Now:D}README.md";

        [Obsolete("Ooh, don't use me. Instead, use." + Name )]
        public MyClass4()
        {
            const string localConst = /*caret*/Name + "test";
            string local = Name + "test";
            const string localConst2 = $@"{Name}test";
        }
    }
}