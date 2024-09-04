Imports System.Console
Module Module1

    Sub Main()
        Dim num, max, min As Integer

        WriteLine("Enter integers one by one, and enter 1 if you wish to exit.")

        num = ReadLine()
        max = num
        min = num

        While num <> 1
            num = ReadLine()
            If num > max Then
                max = num
            ElseIf num < min Then
                min = num
            End If
        End While

        WriteLine("Max: " & max)
        WriteLine("Min: " & min)

        ReadKey()
    End Sub

End Module
