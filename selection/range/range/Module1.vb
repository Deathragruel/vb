Imports System.Console
Module Module1

    Sub Main()
        Dim num As Integer

        WriteLine("Enter number to check if its between 21 and 29 inclusive.")

        num = ReadLine()

        If num >= 21 And num <= 29 Then
            WriteLine("Within range")
        ElseIf num > 29 Then
            WriteLine("Above range")
        Else
            WriteLine("Below range")
        End If

        ReadKey()
    End Sub

End Module
