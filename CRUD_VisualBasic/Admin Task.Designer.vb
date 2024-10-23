<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Task
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Task))
        btn_buscar = New Button()
        btn_agregar = New Button()
        btn_eliminar = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' btn_buscar
        ' 
        btn_buscar.BackColor = Color.White
        btn_buscar.BackgroundImage = CType(resources.GetObject("btn_buscar.BackgroundImage"), Image)
        btn_buscar.BackgroundImageLayout = ImageLayout.Center
        btn_buscar.Cursor = Cursors.Hand
        btn_buscar.Font = New Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_buscar.ForeColor = Color.RoyalBlue
        btn_buscar.Location = New Point(48, 228)
        btn_buscar.Name = "btn_buscar"
        btn_buscar.Size = New Size(307, 218)
        btn_buscar.TabIndex = 3
        btn_buscar.Text = "Buscar"
        btn_buscar.TextAlign = ContentAlignment.BottomCenter
        btn_buscar.UseVisualStyleBackColor = False
        ' 
        ' btn_agregar
        ' 
        btn_agregar.BackgroundImage = My.Resources.Resources.agregar1
        btn_agregar.BackgroundImageLayout = ImageLayout.Center
        btn_agregar.Cursor = Cursors.Hand
        btn_agregar.Font = New Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_agregar.ForeColor = Color.MediumSeaGreen
        btn_agregar.Location = New Point(384, 229)
        btn_agregar.Name = "btn_agregar"
        btn_agregar.Size = New Size(305, 218)
        btn_agregar.TabIndex = 4
        btn_agregar.Text = "Agregar"
        btn_agregar.TextAlign = ContentAlignment.BottomCenter
        btn_agregar.UseVisualStyleBackColor = True
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.BackColor = Color.White
        btn_eliminar.BackgroundImage = CType(resources.GetObject("btn_eliminar.BackgroundImage"), Image)
        btn_eliminar.BackgroundImageLayout = ImageLayout.Center
        btn_eliminar.Cursor = Cursors.Hand
        btn_eliminar.Font = New Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_eliminar.ForeColor = Color.Tomato
        btn_eliminar.Location = New Point(707, 229)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(307, 218)
        btn_eliminar.TabIndex = 5
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.TextAlign = ContentAlignment.BottomCenter
        btn_eliminar.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.RoyalBlue
        Label4.Location = New Point(61, 570)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 18)
        Label4.TabIndex = 8
        Label4.Text = "Buscar: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.MediumSeaGreen
        Label5.Location = New Point(50, 592)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 18)
        Label5.TabIndex = 9
        Label5.Text = "Agregar:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.Tomato
        Label6.Location = New Point(52, 616)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 18)
        Label6.TabIndex = 10
        Label6.Text = "Eliminar:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century Gothic", 7.8F)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(123, 568)
        Label7.Name = "Label7"
        Label7.Size = New Size(346, 17)
        Label7.TabIndex = 11
        Label7.Text = "Busca clientes para sumarles o restarles en su cuenta"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Century Gothic", 7.8F)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(121, 592)
        Label8.Name = "Label8"
        Label8.Size = New Size(295, 17)
        Label8.TabIndex = 12
        Label8.Text = "Agrega un nuevo cliente a tu base de datos"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Century Gothic", 7.8F)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(121, 616)
        Label9.Name = "Label9"
        Label9.Size = New Size(222, 17)
        Label9.TabIndex = 13
        Label9.Text = "Elimina clientes que ya no existen"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.RoyalBlue
        Label10.Location = New Point(353, 97)
        Label10.Name = "Label10"
        Label10.Size = New Size(398, 59)
        Label10.TabIndex = 14
        Label10.Text = "GESTOR DE CLIENTES"
        ' 
        ' Admin_Task
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1060, 670)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btn_eliminar)
        Controls.Add(btn_agregar)
        Controls.Add(btn_buscar)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Admin_Task"
        Text = "Admin_Task"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
