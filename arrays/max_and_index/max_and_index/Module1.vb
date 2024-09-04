Imports System.Console
Module Module1

    Sub Main()
        Dim amount, index, max, max_index As Integer

        WriteLine("How many values do you wish to enter?")
        amount = ReadLine()

        Dim values(amount - 1) As Integer

        WriteLine("Enter " & amount & " values.")

        values(0) = ReadLine()
        max = values(0)

        For index = 1 To (amount - 1)
            values(index) = ReadLine()
            If values(index) > max Then
                max = values(index)
                max_index = index
            End If
        Next

        WriteLine("Max value entered: " & max)
        WriteLine("Index location in list: " & max_index)

        ReadKey()
    End Sub

End Module
