Imports System.Console
Module Module1

    Sub Main()
        Dim index, num, max, min As Integer

        WriteLine("Enter 8 integers one by one.")

        num = ReadLine()
        max = num
        min = num
        For index = 1 To 7
            num = ReadLine()
            If num > max Then
                max = num
            ElseIf num < min Then
                min = num
            End If
        Next
        WriteLine("Max: " & max)
        WriteLine("Min: " & min)

        ReadKey()
    End Sub

End Module
