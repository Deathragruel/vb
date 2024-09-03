Imports System.Console
Module Module1

    Sub Main()
        Dim num1, num2, result As Double

        WriteLine("Enter two real numbers one by one for multiplication rounded to two dp.")
        num1 = ReadLine()
        num2 = ReadLine()
        result = num1 * num2
        WriteLine("Here's your answer: " & Format(result, "#########.##"))

        ReadKey()
    End Sub

End Module
