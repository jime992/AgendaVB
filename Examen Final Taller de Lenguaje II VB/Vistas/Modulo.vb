Imports Clases
Module Modulo
    Public ListaAmigos As List(Of Amigo) = New List(Of Amigo)
    Public UnAmigo As Amigo



    Public Function controlarnonum(e As KeyPressEventArgs) As KeyPressEventArgs
        If (Not IsNumeric(e.KeyChar) = False) Then
            e.Handled = True
        End If
        Return e
    End Function

    Public Sub msjdecumpleaños(amig As Amigo)
        Dim dias As Integer = amig.calcdias

        If (dias < 0) Then
            MsgBox("Amigo Guardado Correctamente, Dias hasta su cumpleaños: " + CStr(dias * (-1)), vbOKOnly, "Agenda")
        Else
            If (dias > 0) Then
                MsgBox("Amigo Guardado Correctamente, Dias desde su cumpleaños: " + CStr(dias), vbOKOnly, "Agenda")
            Else 'si dias = 0 entonces hoy es su cumpleaños
                MsgBox("Amigo Guardado Correctamente, Hoy es su cumpleaños!!!", vbOKOnly, "Agenda")
            End If
        End If
    End Sub
End Module
