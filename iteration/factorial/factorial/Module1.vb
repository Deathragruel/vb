Imports System.Console
Module Module1

    Sub Main()
        Dim index, num, total As Integer

        WriteLine("Enter n such that you wish to calculate n!, where n is a + integer.")

        num = ReadLine()

        total = 1
        For index = 1 To num
            total = total * index
        Next

        If num > 0 Then
            WriteLine(num & "! = " & total)
        ElseIf num = 0 Then
            WriteLine("0! = 1")
        Else
            WriteLine("No value of n! for n<0.")
        End If


        ReadKey()
    End Sub

End Module
