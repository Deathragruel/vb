Imports System.Console
Module Module1

    Sub Main()
        Dim length, width, depth As Double

        Write("Enter the length, width, and depth of a rectangular swimming pool ")
        WriteLine("to calculate its volume.")

        length = ReadLine()
        width = ReadLine()
        depth = ReadLine()

        WriteLine("Volume: " & (length * width * depth))

        ReadKey()
    End Sub

End Module
