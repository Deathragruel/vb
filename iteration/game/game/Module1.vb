Imports System.Console
Module Module1

    Sub Main()
        Dim random_num, guessing_num As Integer

        Randomize()
        random_num = (1000 * Rnd()) + 1

        WriteLine("Keep guessing till you get the right number from 1 to 1000.")

        Do
            guessing_num = ReadLine()

            If guessing_num < random_num Then
                WriteLine("Too low.")
            ElseIf guessing_num > random_num Then
                WriteLine("Too high.")
            End If

        Loop Until guessing_num = random_num

        WriteLine("You win!")

        ReadKey()
    End Sub

End Module
