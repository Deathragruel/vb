Imports System.Console
Module Module1

    Sub Main()
        Dim num, result As Integer
        Dim binary As String

        WriteLine("Enter a number you wish to convert into binary.")

        num = ReadLine()

        If num = 0 Then
            WriteLine("0")
            Exit Sub
        End If

        binary = ""
        result = num
        While result > 0
            binary = binary & (result Mod 2)
            result = result \ 2
        End While

        WriteLine(StrReverse(binary))

        ReadKey()
    End Sub

End Module
