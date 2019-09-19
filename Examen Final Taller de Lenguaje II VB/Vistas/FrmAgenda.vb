Imports System.ComponentModel
Imports Clases

Public Class FrmAgenda

    Private Sub FrmAgenda_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MsgBox("Desea Salir?", vbYesNo, "Salir") = vbNo Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        e = controlarnonum(e) 'controlo que no se ingresen numeros
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        e = controlarnonum(e) 'controlo que no se ingresen numeros
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nom As String = txtNombre.Text
        Dim ape As String = txtApellido.Text
        Dim fechNac As Date = dtpFechaNac.Value

        If ((nom = "") Or (ape = "") Or (fechNac > Today)) Then
            MsgBox("Faltan Datos o Fecha Incorrecta", vbOKOnly, "Error")
        Else
            UnAmigo = New Amigo(ape, nom, fechNac)
            lblEdad.Text = "Edad: " + CStr(UnAmigo.getEdad)
            lblSigno.Text = "Signo: " + CStr(UnAmigo.SignoZodiacal)
            ListaAmigos.Insert(ListaAmigos.Count, UnAmigo)
            msjdecumpleaños(UnAmigo)

        End If

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtApellido.Clear()
        txtNombre.Clear()
        dtpFechaNac.Value = Today
        lblEdad.Text = " "
        lblSigno.Text = " "
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.Hide()
        frmDatos.Show()
    End Sub

End Class
