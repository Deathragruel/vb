Imports System.Console
Module Module1

    Sub Main()
        Dim length, breadth As Double

        WriteLine("Enter length and breadth of a rectangle to output area.")
        length = ReadLine()
        breadth = ReadLine()
        WriteLine("Area: " & (length * breadth))

        ReadKey()
    End Sub

End Module
