namespace MixedDeconstruction
{
    public class UseInGeneric<T>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public T GenericProperty { get; set; }
    }
}