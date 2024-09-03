Imports System.Console

Module Module1

    Sub Main()
        Dim pounds, exchange_rate As Double

        WriteLine("Enter an amount of money in pounds for conversion to euros.")
        WriteLine("Afterward, enter the exchange rate you wish to use. (Standard is 1.15)")

        pounds = ReadLine()
        exchange_rate = ReadLine()

        WriteLine("Converted: " & (exchange_rate * pounds) & ChrW(&HA3))

        ReadKey()
    End Sub

End Module
