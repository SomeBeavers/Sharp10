// Sharp10 Framework SealedRecordToString.cs

namespace Framework
{
    abstract record MyRec()
    {
        public sealed override string ToString() => base.ToString();
    }

    record Derived1() : MyRec()
    {
       // public override string ToString() => base.ToString();
    }
}