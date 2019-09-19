Public Class Amigo
    Dim Apellido As String
    Dim Nombre As String
    Dim FechaNacimiento As Date
    Private NombreCompleto As String
    Dim edad As Integer

    Public Sub New(ap As String, nom As String, fecnac As Date)
        Apellido = ap
        Nombre = nom
        FechaNacimiento = fecnac
    End Sub

    Public Function GetFechaNacimiento() As Date
        Return FechaNacimiento
    End Function

    Public ReadOnly Property NomCompleto As String
        Get
            Return Apellido + " " + Nombre
        End Get
    End Property

    Public Sub CalcEdad()
        Dim fechaactual As Date = Today  'un auxiliar con la fecha actual

        'me fijo si el mes de nacimiento es menor que el mes acutal
        If (FechaNacimiento.Month < fechaactual.Month) Then 'si es menor entonces la edad es año actual - año de nacimiento
            edad = fechaactual.Year - FechaNacimiento.Year
        Else
            If (FechaNacimiento.Month > fechaactual.Month) Then ' si es mayor entonces la edad es (año actual - año de nacimiento) - 1 porque todavia no cumplio años
                edad = (fechaactual.Year - FechaNacimiento.Year) - 1
            Else 'si el mes de nacimiento es igual al mes actual entonces
                If ((FechaNacimiento.Day) <= (fechaactual.Day)) Then 'me fijo si el dia ya paso, si ya paso(o está pasando) entonces
                    edad = (fechaactual.Year - FechaNacimiento.Year) 'edad es año actual menos la fecha de nacimiento
                Else 'si todavia no pasó el dia de su cumpleaños entonces 
                    edad = (fechaactual.Year - FechaNacimiento.Year) - 1 'edad es igual a (año actual - año de nacimiento) - 1
                End If
            End If
        End If

    End Sub

    Public Function getEdad() As Integer
        CalcEdad()
        Return edad
    End Function

    Public Function calcdias() As Integer
        Dim fechaactual As Date = Today
        Dim fechaaux As Date = FechaNacimiento
        Dim dias As Integer

        'en la fecha auxiliar guardo el dia de cumpleaños y el mes de cumpleaños , pero pongo el año actual para poder restar dias
        fechaaux = FechaNacimiento.AddYears(DateDiff(DateInterval.Year, FechaNacimiento, fechaactual))

        'hago la diferencia de dias entre la fecha auxiliar y la fecha actual
        dias = DateDiff(DateInterval.Day, fechaaux, fechaactual)

        Return dias
    End Function

    Public Function SignoZodiacal() As String
        Select Case FechaNacimiento.Month
            Case 1
                If (Antesdel22(FechaNacimiento) = True) Then
                    Return "Capricornio"
                Else
                    Return "Acuario"
                End If
            Case 2
                If (Antesdel22(FechaNacimiento) = True) Then
                    Return "Acuario"
                Else
                    Return "Piscis"
                End If
            Case 3
                If (Antesdel22(FechaNacimiento) = True) Then
                    Return "Piscis"
                Else
                    Return "Aries"
                End If
            Case 4
                If (Antesdel22(FechaNacimiento) = True) Then
                    Return "Aries"
                Else
                    Return "Tauro"
                End If
            Case 5
                If (Antesdel22(FechaNacimiento) = True) Then
                    Return "Tauro"
                Else
                    Return "Geminis"
                End If
            Case 6
                If (Antesdel22(FechaNacimiento) = True) Then
                    Return "Geminis"
                Else
                    Return "Cancer"
                End If
            Case 7
                If (Antesdel22(FechaNacimiento) = True) Then
                    Return "Cancer"
                Else
                    Return "Leo"
                End If
            Case 8
                If (Antesdel22(FechaNacimiento) = True) Then
                    Return "Leo"
                Else
                    Return "Virgo"
                End If
            Case 9
                If (Antesdel22(FechaNacimiento) = True) Then
                    Return "Virgo"
                Else
                    Return "Libra"
                End If
            Case 10
                If (Antesdel22(FechaNacimiento) = True) Then
                    Return "Libra"
                Else
                    Return "Escorpio"
                End If
            Case 11
                If (Antesdel22(FechaNacimiento) = True) Then
                    Return "Escorpio"
                Else
                    Return "Sagitario"
                End If
            Case 12
                If (Antesdel22(FechaNacimiento) = True) Then
                    Return "Sagitario"
                Else
                    Return "Capricornio"
                End If
        End Select
    End Function

    Public Function Antesdel22(fecha As Date) As Boolean
        If (fecha.Day <= 21) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
