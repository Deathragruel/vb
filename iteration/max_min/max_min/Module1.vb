Imports System.Console
Module Module1

    Sub Main()
        Dim index As Integer
        Dim num, max, min As Double

        WriteLine("Enter 10 numbers for attaining maximum and minimum values.")

        num = ReadLine()
        max = num
        min = num
        For index = 1 To 9
            num = ReadLine()
            If num > max Then
                max = num
            ElseIf num < min Then
                min = num
            End If
        Next

        WriteLine("")
        WriteLine("Max: " & max)
        WriteLine("Min: " & min)

        ReadKey()
    End Sub

End Module
