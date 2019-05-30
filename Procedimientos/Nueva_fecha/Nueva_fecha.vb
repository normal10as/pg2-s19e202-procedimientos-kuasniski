Imports System

Module Nueva_fecha
    Sub Main(args As String())
        Dim DiasIngresado As Int16
        Dim FechaIngresada As Date
        Console.Write("Ingrese una fecha: ")
        FechaIngresada = Console.ReadLine
        Console.Write("Ingrese cantidad de dias: ")
        DiasIngresado = Console.ReadLine
        Console.WriteLine("La nueva fecha es: " & FechaNueva(DiasIngresado, FechaIngresada))
        Console.Read()

    End Sub

    Function FechaNueva(CantDias As Int16, Fecha As Date) As Date
        Return Fecha.AddDays(CantDias)
    End Function
End Module
