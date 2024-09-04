Imports System.Console
Module Module1

    Sub Main()
        Dim index As Integer
        Dim names(5) As String

        WriteLine("Enter 6 names.")

        For index = 0 To 5
            names(index) = ReadLine()
        Next

        WriteLine("")

        For index = 0 To 5
            WriteLine(names(index))
        Next

        WriteLine("")

        For index = 5 To 0 Step -1
            WriteLine(names(index))
        Next


        ReadKey()
    End Sub

End Module
