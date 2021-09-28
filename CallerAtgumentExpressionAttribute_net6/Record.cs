// Sharp10 CallerArgumentExpressionAttribute_net6 Record.cs

namespace CallerArgumentExpressionAttribute_net6
{
    public record Record(string Name, int Age, 
        [CallerArgumentExpression("Name")]string text = "")
    {
        public Record(string name, [CallerArgumentExpression("name")]string text = "") : this(name, 1)
        {
            Name = name;
        }

        public void Deconstruct(out string name, out int age, 
            [CallerArgumentExpression("age")]string text = "")
        {
            name = Name;
            age = Age;
        }
    }
}