// Sharp10 SealedRecordToString QF_SetLanguageVersion.cs

namespace SealedRecordToString
{
    abstract record MyRec()
    {
        public sealed override string ToString() => base.ToString();
    }

    class MyClass
    {
        public sealed override string ToString() => base.ToString();

        private void Test()
        {
            var s = this.ToString();
        }
    }
}