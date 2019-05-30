Imports System
Imports System.DateTime
Module AhoraEs
    Sub Main(args As String())

        MostrarFechaActual()
        Console.Write("La hora es: " & MostrarHoraActual())
        Console.Read()

    End Sub

    Sub MostrarFechaActual()
        Console.WriteLine("Hoy es: " & Now.Date)
    End Sub

    Function MostrarHoraActual() As Date
        Return Now.Hour & ":" & Now.Minute & ":" & Now.Second
    End Function
End Module
