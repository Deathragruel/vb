Imports System.Console
Module Module1

    Sub Main()
        Dim num As Integer

        WriteLine("Enter a number corresponding to a month(1-12).")

        num = ReadLine()

        Select Case num
            Case 1 : Console.WriteLine("January")
            Case 2 : Console.WriteLine("February")
            Case 3 : Console.WriteLine("March")
            Case 4 : Console.WriteLine("April")
            Case 5 : Console.WriteLine("May")
            Case 6 : Console.WriteLine("June")
            Case 7 : Console.WriteLine("July")
            Case 8 : Console.WriteLine("August")
            Case 9 : Console.WriteLine("September")
            Case 10 : Console.WriteLine("October")
            Case 11 : Console.WriteLine("November")
            Case 12 : Console.WriteLine("December")
            Case Else : Console.WriteLine("Number invalid.")
        End Select

        ReadKey()
    End Sub

End Module
