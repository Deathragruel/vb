Imports System.Console
Module Module1

    Sub Main()
        'Had to get help for this code
        Dim i, j As Integer

        WriteLine("Enter n for a latin square of size n.")
        Dim n As Integer = ReadLine()
        Dim latin_square(n - 1, n - 1) As Integer

        For i = 0 To (n - 1)
            For j = 0 To (n - 1)
                latin_square(i, j) = ((i + j) Mod n) + 1
            Next
        Next

        For i = 0 To (n - 1)
            For j = 0 To (n - 1)
                Console.Write(latin_square(i, j) & " ")
            Next
            Console.WriteLine()
        Next

        ReadKey()
    End Sub

End Module
