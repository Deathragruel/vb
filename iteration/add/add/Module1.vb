Imports System.Console
Module Module1

    Sub Main()
        Dim num, total, counter As Double

        WriteLine("Enter numbers infinitely till you don't want to, then enter 0.")

        total = 0
        counter = 0
        Do
            num = ReadLine()
            total += num
            counter += 1
        Loop Until num = 0
        counter -= 1

        WriteLine("Total: " & total)
        WriteLine("Average: " & (total / counter).ToString("F2"))

        ReadKey()
    End Sub

End Module
