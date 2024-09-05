Imports System.Console
Module Module1

    Sub Main()
        Dim i, score As Integer
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
        Dim questions(,) As String = {
            {"How many continents are there?", "7"},
            {"How many oceans are there?", "4"},
            {"How many countries are there?", "195"},
            {"How many US states are there?", "50"},
            {"The country of South Korea has how many provinces?", "9"}
        }

        WriteLine("Guess 10 country capitals.")
        WriteLine("")

        score = 0
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
                score += 1
            End If
            WriteLine("")
        Next

        WriteLine("Alright, you got " & score & "/10. It's time for a quiz.")
        score = 0
        For i = 0 To 4
            WriteLine(questions(i, 0))
            guess = ReadLine()
            If guess = questions(i, 1) Then
                WriteLine("Correct")
                score += 1
            Else
                WriteLine("Incorrect")
            End If
        Next

        ReadKey()
    End Sub

End Module
