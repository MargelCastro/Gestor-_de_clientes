Imports System.Data.SqlClient
Imports System.Resources
Public Class Login
    Private conexion As SqlConnection
    Private comando As SqlCommand

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion = New SqlConnection("server=HBLANCO-SJOL21\SQLEXPRESS;database=Gestor;integrated security=true")
            Debug.WriteLine("Connection initialized successfully.")
        Catch ex As Exception
            MessageBox.Show("Error initializing connection: " & ex.Message)
            Debug.WriteLine("Error initializing connection: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        If conexion Is Nothing Then
            MessageBox.Show("Connection has not been initialized.")
            Return
        End If

        Try
            conexion.Open()
            Debug.WriteLine("Connection opened successfully.")

            ' SQL query with parameters to prevent SQL injection
            Dim consulta As String = "select * from Usuarios where Loggin = '" & txt_user.Text & "' and Pass = '" & txt_pass.Text & "' "
            comando = New SqlCommand(consulta, conexion)
            Debug.WriteLine("Connection opened successfully.")
            Debug.WriteLine("consulta: " & consulta)

            Dim lector As SqlDataReader = comando.ExecuteReader()

            ' Check if any rows match the criteria
            If lector.HasRows Then
                Me.Hide()
                menu_principal.ShowDialog()
            Else
                MessageBox.Show("Verifique los datos ingresados nuevamente...")
            End If

            lector.Close()
        Catch ex As MissingManifestResourceException
            MessageBox.Show("Resource error: " & ex.Message)
            Debug.WriteLine("Resource error: " & ex.Message)
        Catch ex As InvalidOperationException
            MessageBox.Show("Operation error: " & ex.Message)
            Debug.WriteLine("Operation error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message)
            Debug.WriteLine("General error: " & ex.Message)
        Finally
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                conexion.Close()
                Debug.WriteLine("Connection closed.")
            End If
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub
End Class
