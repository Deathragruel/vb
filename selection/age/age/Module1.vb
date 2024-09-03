Imports System.Console
Module Module1

    Sub Main()
        Dim age As String

        WriteLine("What is your age?")
        age = ReadLine()

        If age >= 18 Then
            WriteLine("You are old enough to drive.")
        Else
            WriteLine("You are not old enough to drive.")
        End If

    End Sub

End Module
