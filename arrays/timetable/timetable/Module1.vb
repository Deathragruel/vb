Imports System.Console
Module Module1

    Sub Main()
        Dim timetable(4, 5) As String
        Dim i, j As Integer

        WriteLine("First, enter all the lessons in Monday then of Tuesday and so on(6 lessons each) till Friday.")
        WriteLine("")
        For i = 0 To 4
            Select Case i
                Case 0 : WriteLine("Monday: ")
                Case 1 : WriteLine("Tuesday: ")
                Case 2 : WriteLine("Wednesday: ")
                Case 3 : WriteLine("Thursday: ")
                Case 4 : WriteLine("Friday: ")
            End Select
            For j = 0 To 5
                timetable(i, j) = ReadLine()
            Next
            WriteLine("")
        Next

        For i = 0 To 4
            Select Case i
                Case 0 : WriteLine("Monday: ")
                Case 1 : WriteLine("Tuesday: ")
                Case 2 : WriteLine("Wednesday: ")
                Case 3 : WriteLine("Thursday: ")
                Case 4 : WriteLine("Friday: ")
            End Select
            For j = 0 To 5
                Write(timetable(i, j) & " ")
            Next
            WriteLine("")
        Next

        ReadKey()
    End Sub

End Module
