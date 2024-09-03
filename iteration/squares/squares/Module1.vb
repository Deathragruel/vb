Imports System.Console

Module Module1

    Sub Main()
        Dim index, count As Integer

        WriteLine("Enter an integer.")

        count = ReadLine()
        WriteLine("")
        WriteLine("")

        For index = 1 To count
            WriteLine(index ^ 2)
        Next

        ReadKey()
    End Sub

End Module
