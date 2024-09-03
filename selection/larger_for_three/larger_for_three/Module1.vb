Imports System.Console
Module Module1

    Sub Main()
        Dim num1, num2, num3 As Double

        WriteLine("Enter three numbers to determine which is largest.")

        num1 = ReadLine()
        num2 = ReadLine()
        num3 = ReadLine()

        If num1 > num2 And num1 > num3 Then
            WriteLine(num1 & " is the largest.")
        ElseIf num2 > num1 And num2 > num3 Then
            WriteLine(num2 & " is the largest.")
        ElseIf num3 > num1 And num3 > num2 Then
            WriteLine(num3 & " is the largest.")
        Else
            WriteLine("All three are equal.")
        End If

        ReadKey()

    End Sub

End Module
