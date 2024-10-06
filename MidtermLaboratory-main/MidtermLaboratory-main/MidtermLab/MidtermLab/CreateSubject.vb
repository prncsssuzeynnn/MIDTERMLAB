Imports MySql.Data.MySqlClient

Public Class CreateSubject
    Public Event SubjectRegistered()
    ' Replace with your actual connection string
    Private connectionString As String = "Server=localhost;Database=midtermlab_db;Uid=root;Pwd=;"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub submit_btn_Click(sender As Object, e As EventArgs) Handles submit_btn.Click
        ' Get the subject code from the textbox
        Dim subjectCode As String = subjectcode_tb.Text
        Dim subjectName As String = subjectname_tb.Text

        ' Check if the subject code is not empty
        If String.IsNullOrWhiteSpace(subjectCode) Or String.IsNullOrWhiteSpace(subjectName) Then
            MessageBox.Show("Please enter a subject code and name.")
            Return
        End If

        ' Use a connection to the database
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim cmd As MySqlCommand = Nothing

            Try
                ' Insert the subject code into the Subjects table
                Dim query As String = "INSERT INTO Subjects (subject_code, subject_name) VALUES (@subjectCode,@subjectName)"
                cmd = New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@subjectCode", subjectCode)
                cmd.Parameters.AddWithValue("@subjectName", subjectName)

                cmd.ExecuteNonQuery()
                RaiseEvent SubjectRegistered()
                MessageBox.Show("Subject created successfully!")
                ClearForm() ' Optional: clear the form after submission
            Catch ex As MySqlException
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub ClearForm()
        ' Clear the subject code textbox
        subjectcode_tb.Clear()
        Me.Close()
    End Sub
End Class
