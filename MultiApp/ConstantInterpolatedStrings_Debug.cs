namespace MultiApp
{
    public class ConstantInterpolatedStrings_Debug
    {
        public const string Name = "test" ;
        public const string Name2 = $"{Name} : name2";

#if NET6_0_OR_GREATER
        public const string Nick1 = $"{Name} - net6";
#endif
#if !NET6_0_OR_GREATER
        public const string Nick1 = $"{Name} - net5";
#endif
    }
}