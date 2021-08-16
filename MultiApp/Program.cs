using System;
using MultiApp;


var name2 = ConstantInterpolatedStrings_Debug.Name2;
Console.WriteLine(name2);

var Name = "test";

string Name2 = $"{Name} : name2";

var Name3 = $"{Name} : name2";

Console.WriteLine(Name2);

(int age, Name) = (1, $"{Name} + nick");

namespace MyNamespace
{
}