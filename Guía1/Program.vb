Imports System

Module Program
    Sub Main(args As String())
        Dim opcion As Integer
        Console.WriteLine("Seleccione la opci�n que desea:")
        opcion = Console.ReadLine

        Select Case opcion
            Case 1
                PrimerPunto()
            Case 2
                SegundoPunto()
            Case 3
                TercerPunto()
            Case 4
                CuartoPunto()
            Case 5
                QuintoPunto()
            Case 6
                SextoPunto()
            Case 7
                SeptimoPunto()
            Case 8
                OctavoPunto()
            Case 9
                NovenoPunto()
            Case 10
                DecimoPunto()
            Case 11
                UndecimoPunto()
            Case 12
                DuodecimoPunto()
        End Select
    End Sub
    Sub PrimerPunto()

        Console.WriteLine("1.Determinar si un n�mero es positivo y par.")

        'Declarar variable
        Dim num1 As Integer

        Console.WriteLine("Ingrese el n�mero:")
        num1 = Console.ReadLine

        If (num1 > 0) Then
            Console.WriteLine("El n�mero es positivo")
            If (num1 Mod 2 = 0) Then
                Console.WriteLine("El n�mero es par")
            Else

                Console.WriteLine("El n�mero es impar")
            End If
        ElseIf (num1 < 0) Then
            Console.WriteLine("El n�mero es negativo")
        Else
            Console.WriteLine("El n�mero es cero")
        End If

    End Sub
    Sub SegundoPunto()

        Console.WriteLine("2.Calcular el cubo de un n�mero entero ingresado por el usuariosolo s�, el n�mero es m�ltiplo de 3 y 5. ")

        'Declarar variables
        Dim num1 As Integer
        Dim cubo As Integer

        Console.WriteLine("Ingrese el n�mero:")
        num1 = Console.ReadLine

        If ((num1 Mod 3 = 0) And (num1 Mod 5 = 0)) Then
            cubo = num1 ^ 3
            Console.WriteLine("El cubo de este n�mero {0} es:{1}", num1, cubo)
        Else
            Console.WriteLine("El n�mero no es m�ltiplo de 3 y 5")
        End If

    End Sub
    Sub TercerPunto()

        Console.WriteLine("3.Calcular el cuadrado de un n�mero entero ingresado por el usuario solo s�, el n�mero esm�ltiplode 4 y 16. ")

        'Declarar variables
        Dim num1 As Integer
        Dim cuadrado As Integer

        Console.WriteLine("Ingrese el n�mero:")
        num1 = Console.ReadLine

        If ((num1 Mod 4 = 0) And (num1 Mod 16 = 0)) Then
            cuadrado = num1 ^ 2
            Console.WriteLine("El cuadrado de {0} es:{1}", num1, cuadrado)
        Else
            Console.WriteLine("El n�mero no es m�ltiplo de 4 y 16")
        End If

    End Sub
    Sub CuartoPunto()

        Console.WriteLine("4.Realizar un algoritmoque permita dar una ponderaci�n cualitativa, seg�n una nota cuantitativa:")

        'Declarar Variables
        Dim nota As Integer

        Console.WriteLine("Ingrese la nota cuantitativa:")
        nota = Console.ReadLine

        Select Case nota
            Case 0 To 40
                Console.WriteLine("Su ponderaci�n cualitativa es: Rango: 0 y 40:P�simo, Aplazado sin oportunidad")
            Case 41 To 45
                Console.WriteLine("Su ponderaci�n cualitativa es: Rango: 41 y 45:Deficiente, Aplazado a reparaci�n")
            Case 46 To 50
                Console.WriteLine("Su ponderaci�n cualitativa es: Rango: 46 y 50:Bajo, Aplazado repetir examen")
            Case 51 To 60
                Console.WriteLine("Su ponderaci�n cualitativa es: Rango: 51 y 60: Regular, No aplazado � Remedial")
            Case 61 To 70
                Console.WriteLine("Su ponderaci�n cualitativa es: Rango: 61 y 70:Bien")
            Case 71 To 80
                Console.WriteLine("Su ponderaci�n cualitativa es: Rango: 71 y 80:Muy Bien")
            Case 81 To 100
                Console.WriteLine("Su ponderaci�n cualitativa es: Rango: 81 y 100:Excelente")
        End Select

    End Sub
    Sub QuintoPunto()
        Console.WriteLine("5.Calcular el pago por galones de gasolina de una estaci�n de servicio, seg�n el tipo de gasolina: ")

        'Declarar Variables
        Dim galones As Double
        Dim litros As Double
        Dim total As Double
        Dim opcion As Integer

        Console.WriteLine("Ingrese la cantidad de gasolina en galones: ")
        galones = Console.ReadLine

        'Operaci�n
        litros = galones * 3.78541

        Console.WriteLine("Ingrese el tipo de gasolina que quiere:" & vbCrLf &
                          "Opci�n 1: Gasolina Premium Extra: 1 litro: 5.000 pesos" & vbCrLf &
                          "Opci�n 2: Gasolina Premium: 1 litro: 3.900 pesos" & vbCrLf &
                          "Opci�n 3: Gasolina Corriente: 1 litro 3.200 pesos" & vbCrLf &
                          "Recuerde poner solo el digito de la opci�n que desee."
                          )
        opcion = Console.ReadLine

        Select Case opcion
            Case 1
                total = litros * 5000
                Console.WriteLine("Usted selecciono Gasolina Premium Extra y su total es: {0}", total)
            Case 2
                total = litros * 3900
                Console.WriteLine("Usted selecciono Gasolina Premium y su total es: {0}", total)
            Case 3
                total = litros * 2900
                Console.WriteLine("Usted selecciono Gasolina Corriente y su total es: {0} pesos", total)
        End Select

        'Resultados
        Console.WriteLine("Su cantidad de gasolina en galones fue:{0}" & vbCrLf &
                          "Su cantidad de gasolina en litros fue:{1}", galones, litros)
    End Sub
    Sub SextoPunto()
        Console.WriteLine("6.Calcular el monto a pagar por el servicio de internet seg�n el nivel del cliente y la cantidad de MB")

        'Declarar Variables
        Dim nivel As Integer
        Dim mb As Integer
        Dim total As Integer


        Console.WriteLine("Ingrese su nivel:")
        nivel = Console.ReadLine

        Console.WriteLine("Ingrese su cantidad de MB:")
        mb = Console.ReadLine

        If (nivel <= 0) Then
            Console.WriteLine("Error:Seleccione un nivel mayor a 0")
        ElseIf (nivel = 1) Then
            total = mb * 5000
            Console.WriteLine("Usted Selecciono el nivel 1, el valor a pagar es 5000 mil pesos por MB, por lo tanto su total es de: {0}", total)
        ElseIf (nivel = 2) Then
            total = mb * 7000
            Console.WriteLine("Usted Selecciono el nivel 2, el valor a pagar es 7000 mil pesos por MB, por lo tanto su total es de: {0}", total)
        ElseIf (nivel = 3) Then
            total = mb * 9000
            Console.WriteLine("Usted Selecciono el nivel 3, el valor a pagar es 9000 mil pesos por MB, por lo tanto su total es de: {0}", total)
        ElseIf (nivel = 4) Then
            total = mb * 15000
            Console.WriteLine("Usted Selecciono el nivel 4, el valor a pagar es 15000 mil pesos por MB, por lo tanto su total es de: {0}", total)
        ElseIf (nivel = 5) Then
            total = mb * 22000
            Console.WriteLine("Usted Selecciono el nivel 5, el valor a pagar es 22000 mil pesos por MB, por lo tanto su total es de: {0}", total)
        ElseIf (nivel = 6) Then
            total = mb * 30000
            Console.WriteLine("Usted Selecciono el nivel 6, el valor a pagar es 30000 mil pesos por MB, por lo tanto su total es de: {0}", total)
        Else
            total = mb * 35000
            Console.WriteLine("Usted Selecciono un nivel mayor o igual a 7, el valor a pagar es 35000 mil pesos por MB, por lo tanto su total es de: {0}", total)
        End If

    End Sub
    Sub SeptimoPunto()

        Console.WriteLine("7.Calcular el sueldo a pagar de un trabajador dado que se debe ingresar la cantidad de horas trabajadas y el valor de la hora en pesos.")

        'Declaracion de variables
        Dim horas As Double
        Const valorOrdinaria As Double = 4166
        Dim total As Double

        Console.WriteLine("Ingrese la cantidad de horas trabajadas ")
        horas = Console.ReadLine

        Console.WriteLine("El valor por hora Ordinaria es de 4166 pesos")

        total = valorOrdinaria * horas
        Console.WriteLine(" Su sueldo a pagar es: {0}", total)

    End Sub
    Sub OctavoPunto()
        Console.WriteLine("8.Calcular el inter�s a pagar por un dinero,colocado a generar inter�s diario.  Se debe ingresar la cantidad de dinero, los d�as que lleva generando inter�s y el inter�s.  Se debe imprimir el inter�s y la cantidad de dinero m�s el inter�s. ")

        'Declaracion de variables
        Dim dinero As Double
        Dim dias As Double
        Dim interes As Double
        Dim operacion As Double
        Dim total As Double
        Dim interesGenerado As Double
        Dim interesTotal As Double

        Console.WriteLine("Ingrese la cantidad de dinero:")
        dinero = Console.ReadLine

        Console.WriteLine("Ingrese los d�as que lleva generando inter�s:")
        dias = Console.ReadLine

        Console.WriteLine("Ingrese el inter�s:")
        interes = Console.ReadLine

        operacion = interes / 100
        interesGenerado = dinero * operacion
        interesTotal = interesGenerado * dias
        total = dinero + interesTotal


        Console.WriteLine("La cantidad de dinero incial es de:{0}", dinero)
        Console.WriteLine("Su Interes generado es de:{0}", interesGenerado)
        Console.WriteLine("Su Interes Total es de:{0}", interesTotal)
        Console.WriteLine("Su total a pagar es:{0}", total)


    End Sub
    Sub NovenoPunto()
        Console.WriteLine("9.Leer dos n�meros enteros y determinar �cu�l de los dos es positivo?")

        Dim numero1 As Long
        Dim numero2 As Long

        Console.WriteLine("Ingrese el n�mero 1:")
        numero1 = Console.ReadLine

        Console.WriteLine("Ingrese el n�mero 2:")
        numero2 = Console.ReadLine

        If (numero1 < 0) Then
            Console.WriteLine("El n�mero 1 es negativo")
        ElseIf (numero1 > 0) Then
            Console.WriteLine("El n�mero 1 es positivo")
        Else
            Console.WriteLine("El n�mero 1 es cero")
        End If
        If (numero2 < 0) Then
            Console.WriteLine("El n�mero 2 es negativo")
        ElseIf (numero2 > 0) Then
            Console.WriteLine("El n�mero 2 es positivo")
        Else

            Console.WriteLine("El n�mero 2 es cero")
        End If

    End Sub
    Sub DecimoPunto()
        Console.WriteLine("10.Realizar un pseudoc�digo que sume 3 n�meros e imprima la suma. ")

        'Declaraci�n de variables
        Dim numero1 As Integer
        Dim numero2 As Integer
        Dim numero3 As Integer
        Dim total As Integer

        Console.WriteLine("Ingrese el numero 1:")
        numero1 = Console.ReadLine

        Console.WriteLine("Ingrese el numero 2:")
        numero2 = Console.ReadLine

        Console.WriteLine("Ingrese el numero 3:")
        numero3 = Console.ReadLine

        total = numero1 + numero2 + numero3

        Console.WriteLine(" El total de la suma de los tres numeros es: {0}", total)

    End Sub
    Sub UndecimoPunto()
        Console.WriteLine("11.Realizar un pseudoc�digo que sume 3 n�meros impares e imprima la suma. ")

        'Declaraci�n de variables
        Dim numero1 As Integer
        Dim numero2 As Integer
        Dim numero3 As Integer
        Dim total As Integer

        Console.WriteLine("Ingrese el numero 1:")
        numero1 = Console.ReadLine

        Console.WriteLine("Ingrese el numero 2:")
        numero2 = Console.ReadLine

        Console.WriteLine("Ingrese el numero 3:")
        numero3 = Console.ReadLine

        If ((numero1 Mod 2 = 0) Or (numero2 Mod 2 = 0) Or (numero3 Mod 2 = 0)) Then
            Console.WriteLine("Deben ser los tres n�meros impares")
        Else
            total = numero1 + numero2 + numero3
            Console.WriteLine("La suma de los numeros es: {0}", total)
        End If

    End Sub
    Sub DuodecimoPunto()
        Console.WriteLine("12.Dado una compra realizada calcular: el iva e imprimir: la compra sin iva, el iva en pesos y el monto con el iva.  Tomar en cuenta que el iva es el 19%. ")
        'Declaraci�n de Variables
        Const iva As Double = 0.19
        Dim montoIva As Double
        Dim total As Double
        Dim compra As Double

        Console.WriteLine("Ingrese el n�mero de la compra:")
        compra = Console.ReadLine

        montoIva = compra * iva
        total = montoIva + compra

        Console.WriteLine("El valor de su compra sin IVA es:{0}" & vbCrLf &
                          "El valor del monto del IVA es:{1}" & vbCrLf &
                          "El valor de su compra con IVA es:{2}", compra, montoIva, total)

    End Sub

End Module
