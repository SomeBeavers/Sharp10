using System.Text;
using Lib;
using Nuget;

namespace SealedRecordToString
{
    public record Derived1 : Lib_SealedRecordToString
    {
    }

    public record Derived2 : Nuget_SealedRecordToString
    {
    }
    public abstract record Parent1(string Name)
    {
        public sealed override string ToString() => base.ToString();

        public record Derived3(string Name) : Parent1(Name)
        {
            //public override string ToString() => base.ToString();
        }
        public record Derived4(string Name) : Parent1(Name)
        {
        }
        public record Derived5(string Name) : Parent1(Name)
        {
        }

        //public sealed virtual bool Equals(Parent1? other) => throw new NotImplementedException();
        //public sealed override int GetHashCode() => base.GetHashCode();
        //protected sealed virtual Type EqualityContract { get; }
        //protected sealed virtual bool PrintMembers(StringBuilder builder) => throw new NotImplementedException();

    }

    class UseRecords
    {
        private void Test()
        {
            new Parent1.Derived3("").ToString();
            new Derived2().ToString();
        }
    }
}