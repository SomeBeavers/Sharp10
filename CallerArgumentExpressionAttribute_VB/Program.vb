Imports System.Runtime.CompilerServices

Module Program
    Sub Main()
        Console.WriteLine("Hello World!")
    End Sub

    Sub Test(s As [Object], <CallerArgumentExpression("S")> s2 As [Object])

    End Sub
End Module
