Imports System.Console
Module Module1

    Sub Main()
        Dim i As Integer
        Dim guess As String

        Dim country_capitals(,) As String = {
            {"Pakistan", "Islamabad"},
            {"Japan", "Tokyo"},
            {"Saudi Arabia", "Riyadh"},
            {"UAE", "Abu Dhabi"},
            {"US", "Washington"},
            {"Canada", "Ottawa"},
            {"Russia", "Moscow"},
            {"India", "Delhi"},
            {"Bangladesh", "Dhaka"},
            {"Brazil", "Brasilia"}
        }

        WriteLine("Guess 10 country capitals.")
        WriteLine("")

        'GetLength(0) gives length of rows, GetLength(1) gives length of columns
        For i = 0 To (country_capitals.GetLength(0) - 1)
            WriteLine("Country is " & country_capitals(i, 0))
            WriteLine("Guess its capital: ")
            guess = ReadLine()
            WriteLine("")
            If guess.ToUpper() <> country_capitals(i, 1).ToUpper() Then
                WriteLine("It was " & country_capitals(i, 1))
            Else
                WriteLine("Correct")
            End If
            WriteLine("")
        Next

        ReadKey()
    End Sub

End Module
