Imports System.ComponentModel

Public Class frmDatos
    Private Sub frmDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To ListaAmigos.Count - 1
            lstAmigos.Items.Add("Nombre Completo: " + ListaAmigos.Item(i).NomCompleto())
            lstAmigos.Items.Add("Fecha de Nacimiento: " + CStr(ListaAmigos.Item(i).GetFechaNacimiento))
            lstAmigos.Items.Add("Signo zodiacal: " + ListaAmigos.Item(i).SignoZodiacal)
            lstAmigos.Items.Add(" ")
            lstAmigos.Items.Add(" ")
        Next
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub frmDatos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmAgenda.Show()
    End Sub
End Class