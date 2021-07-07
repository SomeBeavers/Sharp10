using System;

namespace Core
{
    public class Class1Base
    {
    }

    public class Class1 : Class1Base
    {
        public const string Name = "Some";
        public const string Surname = "Beavers";
        public const string Nickname = /*caret*/$"{Name}{Surname}";
    }

    class Class2
    {
        private void Test()
        {
            const string Name = "Some";
            const string Surname = "Beavers";

            const string Nickname = /*caret*/$"{Name}{Surname}";
        }
    }
}
