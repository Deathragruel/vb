Imports System.Console
Module Module1

    Sub Main()
        Dim index As Integer
        Dim sum, num As Double

        WriteLine("Enter 10 numbers one by one for sum and average.")

        sum = 0
        For index = 1 To 10
            num = ReadLine()
            sum = sum + num
        Next

        WriteLine("Sum: " & sum)
        WriteLine("Average: " & (sum / 10).ToString("F2"))

        ReadKey()
    End Sub

End Module
