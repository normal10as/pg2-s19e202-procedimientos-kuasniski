Imports System

Module SuperficieFiguras
    Sub Main(args As String())
        Dim opcion As Int16
        Dim LadoIngresado, BaseIngresada, BaseMayorIngresada, AlturaIngresada As Single
        Console.WriteLine("//////////////////////////////// MENU //////////////////////////////////////")
        Console.Write("Que deseas calcular: 1=Cuadrado 2=Rectángulo 3=Trapecio ")
        opcion = Console.ReadLine
        Select Case opcion
            Case 1
                Console.Write("Ingrese el lado: ")
                LadoIngresado = Console.ReadLine
                Console.WriteLine("Superficie del cuadrado: " & CalcularSuperficie(LadoIngresado))
            Case 2
                Console.Write("Ingrese base: ")
                BaseIngresada = Console.ReadLine
                Console.Write("Ingrese altura: ")
                AlturaIngresada = Console.ReadLine
                Console.WriteLine("Superficie del rectángulo: " & CalcularSuperficie(BaseIngresada, AlturaIngresada))
            Case 3
                Console.Write("Ingrese la base mayor: ")
                BaseMayorIngresada = Console.ReadLine
                Console.Write("Ingrese la base menor: ")
                BaseIngresada = Console.ReadLine
                Console.Write("Ingrese la altura: ")
                AlturaIngresada = Console.ReadLine
                Console.WriteLine("Superficie del trapecio: " & CalcularSuperficie(BaseMayorIngresada, BaseIngresada, AlturaIngresada))
        End Select
        Console.Read()

    End Sub

    Function CalcularSuperficie(Lado As Single) As Decimal
        Return Lado * Lado
    End Function

    Function CalcularSuperficie(Base As Single, Altura As Single) As Single
        Return Base * Altura
    End Function
    Function CalcularSuperficie(BaseMayor As Single, BaseMenor As Single, Arltura As Single) As Single
        Return ((BaseMayor + BaseMenor) / 2) * Arltura
    End Function
End Module
