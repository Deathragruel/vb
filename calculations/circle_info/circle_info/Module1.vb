Imports System.Console
Module Module1

    Sub Main()
        Dim radius As Double

        WriteLine("Enter radius of a circle for circumference and area.")
        radius = ReadLine()
        WriteLine("Circumferemnce: " & Format(2 * Math.PI * radius, "##########.##"))
        WriteLine("Area: " & Format((Math.PI ^ 2) * radius, "##########.##"))

        ReadKey()
    End Sub

End Module
