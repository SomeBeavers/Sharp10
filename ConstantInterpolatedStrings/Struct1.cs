namespace ConstantInterpolatedStrings
{
    public struct Struct1
    {
        public const string Const1 = "const1";
        public const string Const2 = $"{Const1} - const2";
    }
}