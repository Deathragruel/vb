Imports System.Console
Module Module1

    Sub Main()
        Dim num As Integer

        Do
            WriteLine("Please enter a number between 10 and 20 inclusive or 0 to exit.")
            num = ReadLine()

        Loop Until num >= 10 And num <= 20 Or num = 0

    End Sub

End Module
