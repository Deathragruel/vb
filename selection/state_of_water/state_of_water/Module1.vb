Imports System.Console
Module Module1

    Sub Main()
        Dim temperature As Double

        WriteLine("Enter temperature of water in celcius without units.")

        temperature = ReadLine()

        If temperature = 0 Then
            WriteLine("The water is freezing.")
        ElseIf temperature = 100 Then
            WriteLine("The water is boiling.")
        ElseIf temperature < 100 And temperature > 0 Then
            WriteLine("The water is not boiling or freezing.")
        Else
            WriteLine("That's not water...")
        End If

        ReadKey()
    End Sub

End Module
