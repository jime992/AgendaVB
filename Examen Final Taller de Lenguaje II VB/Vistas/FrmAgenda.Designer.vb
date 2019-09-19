<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgenda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblSigno = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apellido: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 183)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha de Nacimiento: "
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(81, 388)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(186, 44)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar Amigo"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(56, 250)
        Me.lblEdad.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(0, 22)
        Me.lblEdad.TabIndex = 4
        '
        'lblSigno
        '
        Me.lblSigno.AutoSize = True
        Me.lblSigno.Location = New System.Drawing.Point(56, 296)
        Me.lblSigno.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSigno.Name = "lblSigno"
        Me.lblSigno.Size = New System.Drawing.Size(0, 22)
        Me.lblSigno.TabIndex = 5
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(297, 43)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(212, 35)
        Me.txtApellido.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(297, 111)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(212, 35)
        Me.txtNombre.TabIndex = 2
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNac.Location = New System.Drawing.Point(309, 170)
        Me.dtpFechaNac.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dtpFechaNac.MaxDate = New Date(2020, 5, 31, 0, 0, 0, 0)
        Me.dtpFechaNac.MinDate = New Date(1960, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(198, 35)
        Me.dtpFechaNac.TabIndex = 3
        Me.dtpFechaNac.Value = New Date(2018, 5, 23, 0, 0, 0, 0)
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(348, 465)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(117, 44)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(309, 388)
        Me.btnMostrar.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(180, 44)
        Me.btnMostrar.TabIndex = 5
        Me.btnMostrar.Text = "Mostrar Amigos"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(99, 465)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(144, 44)
        Me.btnBorrar.TabIndex = 6
        Me.btnBorrar.Text = "Limpiar Datos"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'FrmAgenda
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(587, 557)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dtpFechaNac)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblSigno)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.Name = "FrmAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda de Amigos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblSigno As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnBorrar As Button
End Class
