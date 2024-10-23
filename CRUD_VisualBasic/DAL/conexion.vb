Imports System.Data.SqlClient
Public Class conexion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Server=localhost;Database=tu_base_de_datos;User Id=tu_usuario;Password=tu_contraseña;"
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                MessageBox.Show("¡Conexión exitosa!")
            Catch ex As Exception
                MessageBox.Show("Error en la conexión: " & ex.Message)
            End Try
        End Using
    End Sub
End Class

