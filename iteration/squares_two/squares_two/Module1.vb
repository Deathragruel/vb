Imports System.Console
Module Module1

    Sub Main()
        Dim index As Integer

        WriteLine("Number  Square of Number")

        For index = 1 To 12
            If index < 10 Then
                WriteLine(index & "             " & index ^ 2)
            Else
                WriteLine(index & "            " & index ^ 2)
            End If
        Next

        ReadKey()
    End Sub

End Module
