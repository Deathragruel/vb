Imports System.Console
Module Module1

    Sub Main()
        Dim height, radius, o_area, c_area, volume As Double

        WriteLine("Hello dear user, i am a program made to cater directly to cylinder lovers.")
        WriteLine("Surface Area and Volume, Open and Closed Cylinders, I cater to all.")
        WriteLine("That's enough bragging. Please enter the height and radius of your precious.")

        height = ReadLine()
        radius = ReadLine()

        o_area = (2 * Math.PI * radius * height)
        c_area = (2 * Math.PI * radius * (height + radius))
        volume = (Math.PI * (radius ^ 2) * height)

        WriteLine("Surface Area of Open Cylinder: " & o_area.ToString("F1"))
        WriteLine("Surface Area of Closed Cylinder: " & c_area.ToString("F1"))
        WriteLine("Volume of a Cylinder: " & volume.ToString("F1"))

        ReadKey()
    End Sub

End Module
