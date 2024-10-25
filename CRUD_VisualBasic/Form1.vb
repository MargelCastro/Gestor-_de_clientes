Imports System.Data.SqlClient

Public Class Login

    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server=REKEDOMINA;database = Gestor; integrated security = true")
    End Sub

    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        conexion.Open()
        Dim consulta As String = "select * from Usuarios   where Loggin = '" & txt_user.Text & "'and Pass = '" & txt_pass.Text & "' "

        comando = New SqlCommand(consulta, conexion)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader

        If lector.HasRows Then
            Me.Hide()
            Admin_Task.ShowDialog()
        Else
            MessageBox.Show("Verifique los datos ingresados nuevamente...")
        End If
    End Sub




    Private Sub btn_inicio_MouseHover(sender As Object, e As EventArgs) Handles btn_inicio.MouseHover
        btn_inicio.BackColor = Color.Tomato
    End Sub

    Private Sub btn_inicio_MouseLeave(sender As Object, e As EventArgs) Handles btn_inicio.MouseLeave
        btn_inicio.BackColor = Color.RoyalBlue

    End Sub



    Private Sub txt_user_TextChanged(sender As Object, e As EventArgs) Handles txt_user.TextChanged

    End Sub

    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged

    End Sub
End Class
