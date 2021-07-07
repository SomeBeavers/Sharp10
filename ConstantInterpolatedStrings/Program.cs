using System;

const string myRootPath = "/src/to/my/root";
const string myWholeFilePath = $"{myRootPath}/README.md";
const string const3 = $"{myRootPath} - const3";
string notConst = $"{myRootPath}/README.md";

Console.WriteLine(myWholeFilePath);

const string Name = "test" ;

// TODO: debugger hints are not shown
const string Name2 = $"{Name} : name2";

string Name3 = $"{Name} : name2";

Console.WriteLine(Name2);

var stringReadmeMd = Sharp10.ConstantInterpolatedStrings.myWholeFilePath;
new Sharp10.ConstantInterpolatedStrings().Test();

Console.WriteLine(const3);