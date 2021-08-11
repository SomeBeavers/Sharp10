namespace MixedDeconstruction
{
    internal class ClassWithDeconstuctor<T>
    {
        public ClassWithDeconstuctor(T genericProperty, string name)
        {
            GenericProperty = genericProperty;
            Name = name;
        }

        public T GenericProperty { get; set; }
        public string Name { get; init; }
        public static T GenericField;

        public void Deconstruct(out T genericProperty, out string name)
        {
            genericProperty = GenericProperty;
            name = Name;
        }
    }
}