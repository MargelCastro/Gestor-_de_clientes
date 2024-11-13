<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label6 = New Label()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(43, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nombre:"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(43, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 25)
        Label2.TabIndex = 0
        Label2.Text = "Apellido"
        Label2.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(52, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 25)
        Label3.TabIndex = 1
        Label3.Text = "Celular"
        Label3.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(54, 136)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 25)
        Label4.TabIndex = 2
        Label4.Text = "Correo"
        Label4.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F)
        Label5.Location = New Point(26, 158)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 25)
        Label5.TabIndex = 3
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(130, 32)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(130, 71)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(130, 104)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(130, 137)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F)
        Label6.Location = New Point(57, 170)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 25)
        Label6.TabIndex = 8
        Label6.Text = "Deuda"
        Label6.TextAlign = ContentAlignment.TopRight
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(130, 170)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(7, 223)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 29)
        Button1.TabIndex = 10
        Button1.Text = "Guardar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(117, 223)
        Button2.Name = "Button2"
        Button2.Size = New Size(125, 29)
        Button2.TabIndex = 11
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(275, 24)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(765, 381)
        DataGridView1.TabIndex = 12
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(12, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 381)
        Panel1.TabIndex = 13
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(7, 188)
        Button3.Name = "Button3"
        Button3.Size = New Size(235, 29)
        Button3.TabIndex = 12
        Button3.Text = "Buscar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' menu_principal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1081, 450)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "menu_principal"
        Text = "Menu Principal"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
End Class
