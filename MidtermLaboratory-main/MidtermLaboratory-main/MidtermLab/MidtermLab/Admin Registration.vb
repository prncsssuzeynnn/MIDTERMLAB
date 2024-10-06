Imports MySql.Data.MySqlClient

Public Class Admin_Registration
    Public Event AddAdmin()
    Private connectionString As String = "Server=localhost;Database=midtermlab_db;Uid=root;Pwd=;"

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Me.Close()
    End Sub

    Private Sub submit_btn_Click(sender As Object, e As EventArgs) Handles submit_btn.Click
        ' Validate input
        If String.IsNullOrWhiteSpace(adminusername_tb.Text) OrElse
           String.IsNullOrWhiteSpace(adminpassword_tb.Text) OrElse
           String.IsNullOrWhiteSpace(adminrepassword_tb.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        If adminpassword_tb.Text <> adminrepassword_tb.Text Then
            MessageBox.Show("Passwords do not match.")
            Return
        End If

        ' Insert admin account into the database
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "INSERT INTO Users (username, password, user_type) VALUES (@username, @password, 'ADMIN')"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", adminusername_tb.Text)
                command.Parameters.AddWithValue("@password", adminpassword_tb.Text) ' Consider hashing the password for security

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Admin account created successfully.")
                    RaiseEvent AddAdmin() ' Trigger event for refreshing data or updating the UI
                    adminusername_tb.Clear()
                    adminpassword_tb.Clear()
                    adminrepassword_tb.Clear()
                    Me.Close() ' Optionally close the form after successful creation
                Else
                    MessageBox.Show("Error creating admin account.")
                End If

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub
End Class
