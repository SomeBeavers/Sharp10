namespace ConstantInterpolatedStrings
{
    public record Record1(string Name2)
    {
        public const string Name = "Some";
        public const string Surname = "Beavers";
        public const string Nickname = $"nick: {Name}{Surname}";
        public const string Nickname2 = $"nick2: {Nickname}";

        public Record1() : this("")
        {
            const string localConst2 = "";
            const string localConst = $"{localConst2}";
        }
    }

    class MyClass3
    {
        private void Test()
        {
            const string s = Record1.Nickname2;
        }
    }
}