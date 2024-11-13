Imports System.Data.SqlClient

Public Class menu_principal
    Private connectionString As String = "server=HBLANCO-SJOL21\SQLEXPRESS;database=Gestor;integrated security=true"

    Private Sub menu_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateDataGridView()
    End Sub

    Private Sub PopulateDataGridView()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "SELECT id, Nombre, Loggin, FechaRegistro, IdUsuarioActualizacion, FechaActualizacion, Activo FROM Usuarios"

                Dim adapter As New SqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                adapter.Fill(dataTable)

                DataGridView1.DataSource = dataTable

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "INSERT INTO Usuarios (Nombre, Loggin, Pass, FechaRegistro, IdUsuarioActualizacion, FechaActualizacion, Activo) " &
                                      "VALUES (@Nombre, @Loggin, @Pass, @FechaRegistro, @IdUsuarioActualizacion, @FechaActualizacion, @Activo)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Nombre", TextBox1.Text)
                    command.Parameters.AddWithValue("@Loggin", New Random().NextInt64())
                    command.Parameters.AddWithValue("@Pass", "")
                    command.Parameters.AddWithValue("@FechaRegistro", DateTime.Now)
                    command.Parameters.AddWithValue("@IdUsuarioActualizacion", 0)
                    command.Parameters.AddWithValue("@FechaActualizacion", DateTime.Now)
                    command.Parameters.AddWithValue("@Activo", 0)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Cliente guardado")
                        PopulateDataGridView()
                    Else
                        MessageBox.Show("No se guardo")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error saving data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
