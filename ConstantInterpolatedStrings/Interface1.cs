namespace ConstantInterpolatedStrings
{
    public interface Interface1<T>
    {
        const string Const1 = $"{nameof(Interface1<string>)} - string";
        const string Const2 = $"{Const1} - string";

        void Test();
    }

    partial class Nterface1<T> : Interface1<T>
    {
        private const string constNew = "my";

        public void Test()
        {
            const string const1 = $"{Interface1<string>.Const1}";

            string local = $"{Interface1<string>.Const1}";
            string loca2 = $"{Interface1<string>.Const1}";
            string loca3 = $"{Interface1<string>.Const1}";
        }
    }

    partial class Nterface1<T>
    {
        private const string const2 = $"{constNew} const";
    }
}