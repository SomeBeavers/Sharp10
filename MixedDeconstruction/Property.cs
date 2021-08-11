namespace MixedDeconstruction
{
    public class Property
    {
        public Property()
        {
            (Prop1, string name, Prop3) = (new InnerClass(), string.Empty, Prop1);
        }

        public InnerClass Prop1 { get; init; }
        public InnerClass Prop2 { get; set; } = null!;
        public InnerClass Prop3 { get; }
        public static InnerClass Prop4 { get; } = null!;

        private void Test()
        {
            (Prop2, string name) = (new InnerClass(), "");
        }
    }

    public class InnerClass
    {
        private void Test()
        {
            new Property() { Prop1 = new InnerClass() };
        }
    }

    class NewClass
    {
        private void Test()
        {
            //(string s, new Property().Prop1) = ("", null);
        }
    }
}