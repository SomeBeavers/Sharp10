using System.Diagnostics;
using CallerArgumentExpressionAttribute_net6;

Console.WriteLine("Hello, World!");
"Wow".ExtensionMethod("", "override");
"Wow".ExtensionMethod("", "");
"Wow".ExtensionMethod("");


LocalFuncInTopLevel(new A() as IA);

Members.PerformCalculation p = (i, i1, s) => { Console.WriteLine(s);};
p(1, 2);

void LocalFuncInTopLevel(IA _classA, 
    [CallerArgumentExpression("_classA")] string text = "")
{
    Console.WriteLine($"LocalFuncInTopLevel: {text}");
}

public class A:IA
{
}

public interface IA
{
}
