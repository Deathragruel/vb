Imports System.Console
Module Module1

    Sub Main()
        Dim hours_worked, hourly_pay, gross_pay As Double

        WriteLine("Enter hours worked this week and hourly pay to calculate gross pay.")

        hours_worked = ReadLine()
        hourly_pay = ReadLine()

        If hours_worked >= 0 And hours_worked <= 40 Then
            gross_pay = (hours_worked * hourly_pay).ToString("F2")
            WriteLine("Gross pay: " & gross_pay)
        ElseIf hours_worked > 40 And hours_worked <= 60 Then
            gross_pay = ((40 * hourly_pay) + ((hours_worked - 40) * hourly_pay * 1.5)).ToString("F2")
            WriteLine("Gross pay: " & gross_pay)
        Else
            WriteLine("Invalid(0<=hours_worked<=60)")
        End If

        ReadKey()
    End Sub

End Module
