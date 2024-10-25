<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar_Clientes
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
        Label1 = New Label()
        btn_GuardarSV = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        txt_DeudaSV = New TextBox()
        txt_CelularSV = New TextBox()
        txt_cedulaSV = New TextBox()
        txt_ApellidoSV = New TextBox()
        txt_nombreSV = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(349, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(560, 59)
        Label1.TabIndex = 6
        Label1.Text = "ADMINISTRADOR DE CLIENTES"
        ' 
        ' btn_GuardarSV
        ' 
        btn_GuardarSV.BackColor = Color.Crimson
        btn_GuardarSV.Cursor = Cursors.Hand
        btn_GuardarSV.FlatStyle = FlatStyle.Flat
        btn_GuardarSV.Font = New Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_GuardarSV.ForeColor = Color.Transparent
        btn_GuardarSV.Location = New Point(588, 585)
        btn_GuardarSV.Name = "btn_GuardarSV"
        btn_GuardarSV.Size = New Size(294, 65)
        btn_GuardarSV.TabIndex = 19
        btn_GuardarSV.Text = "Eliminar"
        btn_GuardarSV.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LimeGreen
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(2, 585)
        Button1.Name = "Button1"
        Button1.Size = New Size(294, 65)
        Button1.TabIndex = 20
        Button1.Text = "Actualizar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(882, 585)
        Button2.Name = "Button2"
        Button2.Size = New Size(294, 65)
        Button2.TabIndex = 21
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.RoyalBlue
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Transparent
        Button3.Location = New Point(295, 585)
        Button3.Name = "Button3"
        Button3.Size = New Size(294, 65)
        Button3.TabIndex = 22
        Button3.Text = "Editar"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' txt_DeudaSV
        ' 
        txt_DeudaSV.Location = New Point(900, 85)
        txt_DeudaSV.Name = "txt_DeudaSV"
        txt_DeudaSV.Size = New Size(254, 27)
        txt_DeudaSV.TabIndex = 32
        ' 
        ' txt_CelularSV
        ' 
        txt_CelularSV.Location = New Point(508, 122)
        txt_CelularSV.Name = "txt_CelularSV"
        txt_CelularSV.Size = New Size(254, 27)
        txt_CelularSV.TabIndex = 31
        ' 
        ' txt_cedulaSV
        ' 
        txt_cedulaSV.Location = New Point(134, 125)
        txt_cedulaSV.Name = "txt_cedulaSV"
        txt_cedulaSV.Size = New Size(254, 27)
        txt_cedulaSV.TabIndex = 30
        ' 
        ' txt_ApellidoSV
        ' 
        txt_ApellidoSV.Location = New Point(508, 89)
        txt_ApellidoSV.Name = "txt_ApellidoSV"
        txt_ApellidoSV.Size = New Size(254, 27)
        txt_ApellidoSV.TabIndex = 29
        ' 
        ' txt_nombreSV
        ' 
        txt_nombreSV.Location = New Point(135, 89)
        txt_nombreSV.Name = "txt_nombreSV"
        txt_nombreSV.Size = New Size(254, 27)
        txt_nombreSV.TabIndex = 28
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(778, 92)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 20)
        Label6.TabIndex = 27
        Label6.Text = "Monto Deuda:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(408, 129)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 20)
        Label5.TabIndex = 26
        Label5.Text = "No Celular:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(34, 132)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 20)
        Label4.TabIndex = 25
        Label4.Text = "No Cedula:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(421, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 24
        Label3.Text = "Apellido:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 20)
        Label2.TabIndex = 23
        Label2.Text = "Nombre:"
        ' 
        ' Buscar_Clientes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1176, 651)
        Controls.Add(txt_DeudaSV)
        Controls.Add(txt_CelularSV)
        Controls.Add(txt_cedulaSV)
        Controls.Add(txt_ApellidoSV)
        Controls.Add(txt_nombreSV)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btn_GuardarSV)
        Controls.Add(Label1)
        Name = "Buscar_Clientes"
        Text = "Buscar_cliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_GuardarSV As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txt_DeudaSV As TextBox
    Friend WithEvents txt_CelularSV As TextBox
    Friend WithEvents txt_cedulaSV As TextBox
    Friend WithEvents txt_ApellidoSV As TextBox
    Friend WithEvents txt_nombreSV As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
