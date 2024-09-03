Imports System.Console
Module Module1

    Sub Main()
        Dim attained_marks, total_marks As Integer
        Dim raw_marks As Double

        WriteLine("Enter attained marks and total marks one by one.")
        attained_marks = ReadLine()
        total_marks = ReadLine()
        raw_marks = attained_marks / total_marks
        WriteLine("Percentage: " & (raw_marks * 100).ToString("F2") & "%")

        ReadKey()
    End Sub

End Module
