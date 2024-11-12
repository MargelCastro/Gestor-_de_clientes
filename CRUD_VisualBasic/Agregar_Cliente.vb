Public Class Agregar_Cliente
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Buscar_Clientes.ShowDialog()
    End Sub
End Class