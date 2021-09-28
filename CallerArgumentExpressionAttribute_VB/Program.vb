Imports System.Runtime.CompilerServices

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
    End Sub

    Sub Test(s As String, <CallerArgumentExpression("S1")> s2 As String)

    End Sub
End Module
