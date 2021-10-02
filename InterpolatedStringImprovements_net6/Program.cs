

using System.Runtime.CompilerServices;

//M($"{args[0]}", 42); // ok
//Handler x = $"{args[0]}"; // error, uncomment ctor to fix

void M([InterpolatedStringHandlerArgument("arg")] Handler handler, int arg)
{
}

[InterpolatedStringHandler]
public ref struct Handler
{
    //public Handler(int literalLength, int formattedCount) { }

    public Handler(int literalLength, int formattedCount, int arg, out bool handlerIsValid)
    {
        handlerIsValid = true;
    }

    public bool AppendLiteral(string s) => true;
    public bool AppendFormatted<T>(T t) => true;
}