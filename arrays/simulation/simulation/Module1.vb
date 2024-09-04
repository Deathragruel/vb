Imports System.Console
Module Module1

    Sub Main()
        Dim die(5), index, random_num As Integer

        Randomize()

        WriteLine("Die throw results of 30 throws: (num:amount)")

        For index = 0 To 5
            die(index) = 0
        Next

        For index = 1 To 30
            random_num = Math.Floor((6 * Rnd()) + 1)
            die(random_num - 1) += 1
        Next

        For index = 1 To 6
            WriteLine(index & ": " & die(index - 1))
        Next

        ReadKey()
    End Sub

End Module
