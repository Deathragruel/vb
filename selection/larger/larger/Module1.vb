Imports System.Console
Module Module1

    Sub Main()
        Dim num1, num2 As Double

        WriteLine("Enter two numbers to check which is larger.")

        num1 = ReadLine()
        num2 = ReadLine()

        If num1 > num2 Then
            WriteLine(num1 & " is larger than " & num2 & ".")
        ElseIf num2 > num1 Then
            WriteLine(num2 & " is larger than " & num1 & ".")
        Else
            WriteLine(num1 & " and " & num2 & "are equal.")
        End If

        ReadKey()
    End Sub

End Module
