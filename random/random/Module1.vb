Imports System.Console
Module Module1
    Sub Main()
        Dim random_num As Integer

        Do

            Randomize()
            random_num = (Rnd() * 6) + 1
            WriteLine(random_num)

        Loop Until random_num = 6

        ReadKey()
    End Sub

End Module
