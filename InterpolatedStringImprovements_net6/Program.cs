using System;
using System.Collections.Generic;
using MyNamespace;

Console.WriteLine();

//AttributeOnRecord.Log(extraParameter: "", handler: $"{new A(),4}");
new Logger2().Log($"{new A().ToString()}");
new Logger2().Log($"{new A().ToString()}");