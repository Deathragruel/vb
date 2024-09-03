Imports System.Console
Module Module1

    Sub Main()
        Dim int1, int2, int3 As Integer
        Dim day, month, year As String
        Dim extra_day As Boolean

        WriteLine("Write three seperate integers one by one to make a date in form dd m/mm yy")

        int1 = ReadLine()
        int2 = ReadLine()
        int3 = ReadLine()
        extra_day = False

        Select Case int1
            Case 1 Or 21 Or 31 : day = int1 & "st "
            Case 2 Or 22 : day = int1 & "nd "
            Case 3 Or 23 : day = int1 & "rd "
            Case Else : day = int1 & "th "
        End Select

        Select Case int2
            Case 1
                month = "January "
                extra_day = True
            Case 2 : month = "February "
            Case 3
                month = "March "
                extra_day = True
            Case 4 : month = "April "
            Case 5
                month = "May "
                extra_day = True
            Case 6 : month = "June "
            Case 7
                month = "July "
                extra_day = True
            Case 8
                month = "August "
                extra_day = True
            Case 9 : month = "September "
            Case 10
                month = "October "
                extra_day = True
            Case 11 : month = "November "
            Case 12
                month = "December "
                extra_day = True
            Case Else : month = "Invalid"
        End Select

        If int1 < 1 Or (int1 > 30 And Not extra_day) Then
            day = "Invalid"
        End If

        If int3 >= 0 And int3 <= 9 Then
            year = 20 & int3 & 0
        ElseIf int3 >= 10 And int3 <= 30 Then
            year = 20 & int3
        ElseIf int3 >= 31 And int3 <= 99 Then
            year = 19 & int3
        Else
            year = "Invalid"
        End If

        WriteLine("Date: " & day & month & year)

        ReadKey()
    End Sub

End Module
