using System;

const string myRootPath = "/src/to/my/root";
const string myWholeFilePath = $"{myRootPath}/README.md";
string notConst = $"{myRootPath}/README.md";

Console.WriteLine(myWholeFilePath);

const string Name = "test" ;

// TODO: debugger hints are not shown
const string Name2 = $"{Name} : name2";

string Name3 = $"{Name} : name2";

Console.WriteLine(Name2);