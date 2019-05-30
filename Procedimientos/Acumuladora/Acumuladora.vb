Imports System

Module Acumuladora
    Sub Main(args As String())
        Dim ValorAcumulado As Decimal = 1
        Console.WriteLine("Valor inicial: " & ValorAcumulado)
        Acumular(ValorAcumulado)
        Console.WriteLine("Valor acumulado: " & ValorAcumulado)
        Acumular(ValorAcumulado)
        Console.WriteLine("Valor acumulado: " & ValorAcumulado)
        Acumular(ValorAcumulado)
        Console.WriteLine("Valor acumulado: " & ValorAcumulado)
        Console.Read()

    End Sub
    Sub Acumular(ByRef ValorAcumular As Decimal)
        ValorAcumular += ValorAcumular
    End Sub
End Module
