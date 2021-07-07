

using System;
using MultiApp;

var name2 = ConstantInterpolatedStrings_Debug.Name2;
Console.WriteLine(name2);

const string Name = "test" ;

string Name2 = $"{Name} : name2";

string Name3 = $"{Name} : name2";

Console.WriteLine(Name2);