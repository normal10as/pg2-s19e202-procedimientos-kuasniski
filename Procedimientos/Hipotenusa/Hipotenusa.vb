Imports System
Imports System.Math
Module Hipotenusa
    Sub Main(args As String())
        Dim aIngresado, bIngresado As Single

        Console.Write("Ingrese el valor de A: ")
        aIngresado = Console.ReadLine()
        Console.Write("Ingrese el valor de B: ")
        bIngresado = Console.ReadLine()
        Console.WriteLine("Hipotenusa: " & CalcularHipotenusa(aIngresado, bIngresado))
        Console.Read()


    End Sub

    Function CalcularHipotenusa(a As Single, b As Single) As Single
        Return Pow(a, 2) + Pow(b, 2)
    End Function
End Module
