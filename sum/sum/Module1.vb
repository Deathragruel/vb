Imports System.Console
Module Module1

    Sub Main()
        Dim num1, num2, num3 As Integer

        WriteLine("Enter three integers one by one to add them all together.")
        num1 = ReadLine()
        num2 = ReadLine()
        num3 = ReadLine()
        WriteLine("Solution: " & (num1 + num2 + num3))

        ReadKey()
    End Sub

End Module
