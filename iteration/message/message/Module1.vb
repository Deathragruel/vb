Imports System.Console
Module Module1

    Sub Main()
        Dim count, index As Integer
        Dim message As String

        WriteLine("Enter a message, and the amount of times it is to be repeated")

        message = ReadLine()
        count = ReadLine()

        For index = 1 To count
            WriteLine(message)
        Next

        ReadKey()
    End Sub

End Module
