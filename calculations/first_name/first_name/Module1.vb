Imports System.Console
Module Module1

    Sub Main()
        Dim name As String

        WriteLine("What is your name?")
        name = ReadLine()
        WriteLine("Hello " & name & ", how's life nowadays?")

        ReadKey()
    End Sub

End Module
