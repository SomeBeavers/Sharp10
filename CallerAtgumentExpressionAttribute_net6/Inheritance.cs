// Sharp10 CallerArgumentExpressionAttribute_net6 Inheritance.cs

namespace CallerArgumentExpressionAttribute_net6
{
    public class Inheritance
    {
        public virtual void OverrideWithRemoved(bool b, int t, 
            [CallerArgumentExpression("t")]string text1 = "", 
            [CallerArgumentExpression("b")]string text2 = "")
        {
        }
    }

    class InheritanceImpl : Inheritance
    {
        public override void OverrideWithRemoved(bool b, int t, string text1 = "", string text2 = "")
        {
            base.OverrideWithRemoved(b, t, text1, text2);
        }
    }

    interface IInterface
    {
        public void OverrideWithRemoved(bool b, int t,
            [CallerArgumentExpression("t")] string text1 = "",
            [My(null)] string text2 = "");
    }

    class Interface : IInterface
    {
        public void OverrideWithRemoved(bool b, int t, string text1 = "", string text2 = "")
        {
            throw new NotImplementedException();
        }
    }
}