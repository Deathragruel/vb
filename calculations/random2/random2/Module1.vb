Imports System.Console
Module Module1

    Sub Main()
        Dim index, random_num As Integer

        For index = 1 To 6
            Randomize()
            random_num = (Rnd() * 6) + 5
            WriteLine(random_num)
        Next

        ReadKey()
    End Sub

End Module
