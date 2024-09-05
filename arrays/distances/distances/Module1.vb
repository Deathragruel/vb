Imports System.Console
Module Module1

    Sub Main()
        Dim index1, index2, i, j As Integer
        Dim place1, place2 As String
        Dim places() As String = {"Lahore", "Multan", "Karachi", "Islamabad", "Quetta"}
        Dim distances(,) As Integer = {
            {0, 342, 1210, 377, 929},
            {342, 0, 882, 543, 589},
            {1210, 882, 0, 1412, 688},
            {377, 543, 1412, 0, 894},
            {929, 589, 688, 894, 0}
        }

        WriteLine("Enter two places to find the distance between them.")
        place1 = ReadLine()
        place2 = ReadLine()

        For i = 0 To 4
            If place1.ToUpper() = places(i).ToUpper() Then
                index1 = i
            ElseIf place2.ToUpper() = places(i).ToUpper() Then
                index2 = i
            End If
        Next

        For i = 0 To 4
            For j = 0 To 4
                If index1 = i And index2 = j Then
                    WriteLine("Distance: " & distances(i, j))
                End If
            Next
        Next

        ReadKey()
    End Sub

End Module