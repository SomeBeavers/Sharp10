// Sharp10 ImprovedDefiniteAssignment Class8.cs

namespace ImprovedDefiniteAssignment
{
#nullable enable
    public class Class8
    {
        private void Test(Type1 myPredefinedType)
        {
            var person1 = new Person(true);
            var person2 = new Person(false);
            var person3 = new Person();

            var person4 = new Person(null, new List<Person?>(){person1, person2, person3});

            var isAdult = person4.Children!?.First()?.IsAdult;
            bool? b = isAdult == false;
            if (b ?? false)
            {
                Console.WriteLine(b);
            }

            (var x1, b) = (person4.Children!?.First()?.IsAdult, b);

            if (x1 ?? true)
            {
                
            }

            if (isAdult is { } x)
            {
                Console.WriteLine(x);
            }


            if (myPredefinedType!?.Person?.IsAdult is { })
            {
                Console.WriteLine();
            }
        }
    }

    internal class Type1
    {
        public Person? Person { get; set; }
    }

    internal class Person
    {
        public Person(bool? IsAdult = null, List<Person?>? Children = null)
        {
            this.IsAdult = IsAdult;
            this.Children = Children;
        }

        public bool? IsAdult { get; init; }
        public List<Person?>? Children { get; init; }

        public void Deconstruct(out bool? IsAdult, out List<Person?>? Children)
        {
            IsAdult = this.IsAdult;
            Children = this.Children;
        }
    }
}