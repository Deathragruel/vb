Imports System.Console
Module Module1

    Sub Main()
        Dim num1, num2 As Integer

        WriteLine("Enter two integers for multiplication.")
        num1 = ReadLine()
        num2 = ReadLine()
        WriteLine("Solution: " & (num1 * num2))

        ReadKey()
    End Sub

End Module
