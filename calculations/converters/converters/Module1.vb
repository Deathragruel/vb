Imports System.Console
Module Module1

    Sub Main()
        Dim celsius, farenheit, inches, stones As Double

        WriteLine("Enter temperature in celsius to convert to farenheit.")

        celsius = ReadLine()
        farenheit = (((9 / 5) * celsius) + 32).ToString("F1")

        WriteLine("Farenheit: " & farenheit)

        WriteLine("")
        WriteLine("Enter inches to convert to centimeter.")

        inches = ReadLine()

        WriteLine("Centimeters: " & (2.54 * inches).ToString("F0"))

        WriteLine("")
        WriteLine("Enter stones to convert to kilograms.")

        stones = ReadLine()

        WriteLine("Kilograms: " & (6.364 * stones).ToString("F1"))

        ReadKey()
    End Sub

End Module
