Imports System
Imports System.Math
Module VolumenCilindro
    Const Pi As Double = 3.14159265
    Sub Main(args As String())
        Dim rIngresado, hIngresado As Single
        Console.Write("Ingrese radio de la base: ")
        rIngresado = Console.ReadLine
        Console.Write("Ingrese la altura: ")
        hIngresado = Console.ReadLine
        Console.WriteLine("Volumen: " & CalcularVolumen(rIngresado, hIngresado))
        Console.Read()
    End Sub

    Function CalcularVolumen(r As Single, h As Single) As Decimal
        Return Pi * Pow(r, 2) * h
    End Function
End Module
