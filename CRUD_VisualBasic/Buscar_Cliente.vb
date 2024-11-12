Public Class Buscar_Clientes
    Private Sub Buscar_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Me.Close()
        Agregar_Cliente.Show()
    End Sub
End Class