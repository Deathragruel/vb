Imports System.Console
Module Module1

    Sub Main()
        Dim index, elements(4) As Integer

        WriteLine("Enter 5 elements for display.")

        For index = 0 To 4
            elements(index) = ReadLine()
        Next
        WriteLine("")
        For index = 0 To 4
            WriteLine(elements(index))
        Next

        ReadKey()
    End Sub

End Module
