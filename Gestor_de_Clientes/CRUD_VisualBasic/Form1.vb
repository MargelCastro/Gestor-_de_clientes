Public Class Login
    Private Sub btn_inicio_MouseHover(sender As Object, e As EventArgs) Handles btn_inicio.MouseHover
        btn_inicio.BackColor = Color.Tomato
    End Sub

    Private Sub btn_inicio_MouseLeave(sender As Object, e As EventArgs) Handles btn_inicio.MouseLeave
        btn_inicio.BackColor = Color.RoyalBlue

    End Sub

    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_user_TextChanged(sender As Object, e As EventArgs) Handles txt_user.TextChanged

    End Sub

    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged

    End Sub
End Class
