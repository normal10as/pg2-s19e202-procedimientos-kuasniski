Imports System
Imports System.Math
Module Potencias

    Sub Main(args As String())
        Dim CantidadInvocada As Int16 = 1
        Dim ValorIngresado As Integer
        Console.Write("Ingrese un valor: ")
        ValorIngresado = Console.ReadLine

        Console.WriteLine("Primer llamdo: " & CalculaPotencias(ValorIngresado, CantidadInvocada))
        Console.WriteLine("Segundo llamado: " & CalculaPotencias(ValorIngresado, CantidadInvocada))
        Console.WriteLine("Tercer llamado: " & CalculaPotencias(ValorIngresado, CantidadInvocada))
        Console.Read()

    End Sub

    Function CalculaPotencias(Valor As Integer, ByRef CantidadInvocada As Int16) As Integer
        Dim Resultado As Integer

        Select Case CantidadInvocada
            Case 1
                Resultado = Pow(Valor, 2)
            Case 2
                Resultado = Pow(Valor, 3)
            Case 3
                Resultado = Pow(Valor, 5)
        End Select

        CantidadInvocada += 1
        Return Resultado

    End Function
End Module
