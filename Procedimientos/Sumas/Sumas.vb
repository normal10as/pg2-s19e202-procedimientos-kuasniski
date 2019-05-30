Imports System

Module Sumas
    Sub Main(args As String())
        Console.WriteLine("Suma de dos valores 2+3 = " & sumar(2, 3))
        Console.WriteLine("Suma de tres valores 2+3+5 = " & sumar(2, 3, 5))
        Console.WriteLine("Suma de cuatro valores 2+3+5+9 = " & sumar(2, 3, 5, 9))
        Console.Read()

    End Sub

    Function sumar(a As Decimal, b As Decimal) As Decimal
        Return a + b
    End Function

    Function sumar(a As Decimal, b As Decimal, c As Decimal) As Decimal
        Return a + b + c
    End Function

    Function sumar(a As Decimal, b As Decimal, c As Decimal, d As Decimal) As Decimal
        Return a + b + c + d
    End Function

End Module
