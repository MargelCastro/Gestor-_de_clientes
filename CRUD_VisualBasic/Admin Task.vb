Public Class Admin_Task
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_buscar_MouseHover(sender As Object, e As EventArgs) Handles btn_buscar.MouseHover
        btn_buscar.BackColor = Color.DodgerBlue
        btn_buscar.ForeColor = Color.White
    End Sub

    Private Sub btn_buscar_MouseLeave(sender As Object, e As EventArgs) Handles btn_buscar.MouseLeave
        btn_buscar.BackColor = Color.White
        btn_buscar.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub btn_agregar_MouseHover(sender As Object, e As EventArgs) Handles btn_agregar.MouseHover
        btn_agregar.BackColor = Color.LimeGreen
        btn_agregar.ForeColor = Color.White
    End Sub

    Private Sub btn_agregar_MouseLeave(sender As Object, e As EventArgs) Handles btn_agregar.MouseLeave
        btn_agregar.BackColor = Color.White
        btn_agregar.ForeColor = Color.MediumSeaGreen
    End Sub

    Private Sub btn_eliminar_MouseHover(sender As Object, e As EventArgs) Handles btn_eliminar.MouseHover
        btn_eliminar.BackColor = Color.DarkOrange
        btn_eliminar.ForeColor = Color.White
    End Sub

    Private Sub btn_eliminar_MouseLeave(sender As Object, e As EventArgs) Handles btn_eliminar.MouseLeave
        btn_eliminar.BackColor = Color.White
        btn_eliminar.ForeColor = Color.Tomato
    End Sub
End Class