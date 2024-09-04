Imports System.Console
Module Module1

    Sub Main()
        Dim pounds As Double

        WriteLine("Pounds   Kilograms")
        For pounds = 1 To 20
            WriteLine("  " & pounds & "          " & (pounds / 2.2).ToString("F2"))
        Next

        ReadKey()
    End Sub

End Module
