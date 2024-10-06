Imports MySql.Data.MySqlClient

Public Class User_Registration
    ' Replace with your actual connection string
    Private connectionString As String = "Server=localhost;Database=midtermlab_db;Uid=root;Pwd=;"
    Public Event UserRegistered()

    Private Sub User_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubjects() ' Load subjects into the CheckedListBox when the form loads
    End Sub

    Private Sub LoadSubjects()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT subject_code FROM Subjects" ' Adjust as needed
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            ' Clear any existing items
            subject_clb.Items.Clear()
            While reader.Read()
                Dim subjectCode As String = reader("subject_code").ToString()
                subject_clb.Items.Add(subjectCode) ' Add subject codes to CheckedListBox
            End While
        End Using
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        ' Close the registration form
        Me.Close()
    End Sub

    Private Sub submit_btn_Click(sender As Object, e As EventArgs) Handles submit_btn.Click
        ' Get the values from the form
        Dim fullname As String = fullname_tb.Text
        Dim gender As String = gender_cb.SelectedItem.ToString()
        Dim contactNumber As String = contact_tb.Text
        Dim department As String = department_cb.SelectedItem.ToString()

        ' Retrieve selected subjects
        Dim selectedSubjects As New List(Of String)()
        For Each item In subject_clb.CheckedItems ' Use CheckedItems for CheckedListBox
            selectedSubjects.Add(item.ToString())
        Next

        ' Debugging: Display selected subjects
        If selectedSubjects.Count = 0 Then
            MessageBox.Show("No subjects selected.")
            Return
        End If

        Dim username As String = username_tb.Text
        Dim password As String = password_tb.Text ' Hash this password before saving for security
        Dim repassword As String = repassword_tb.Text ' Get the value from repassword_tb

        ' Check if passwords match
        If password <> repassword Then
            MessageBox.Show("Passwords do not match.")
            Return
        End If

        ' Use a connection to the database
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim cmdUser As MySqlCommand = Nothing
            Dim cmdStudent As MySqlCommand = Nothing
            Dim cmdSubject As MySqlCommand = Nothing

            Try
                ' Insert into the Users table
                Dim queryUser As String = "INSERT INTO Users (username, password, user_type) VALUES (@username, @password, 'Student')"
                cmdUser = New MySqlCommand(queryUser, connection)
                cmdUser.Parameters.AddWithValue("@username", username)
                cmdUser.Parameters.AddWithValue("@password", password) ' Remember to hash the password
                cmdUser.ExecuteNonQuery()
                MessageBox.Show("User inserted successfully.")

                ' Get the auto-generated User ID
                Dim userId As Integer = CType(cmdUser.LastInsertedId, Integer)

                ' Insert into the Students table
                Dim queryStudent As String = "INSERT INTO Students (name, gender, contact_number, department, user_id) VALUES (@name, @gender, @contactNumber, @department, @userId)"
                cmdStudent = New MySqlCommand(queryStudent, connection)
                cmdStudent.Parameters.AddWithValue("@name", fullname)
                cmdStudent.Parameters.AddWithValue("@gender", gender)
                cmdStudent.Parameters.AddWithValue("@contactNumber", contactNumber)
                cmdStudent.Parameters.AddWithValue("@department", department)
                cmdStudent.Parameters.AddWithValue("@userId", userId)
                cmdStudent.ExecuteNonQuery()
                MessageBox.Show("Student inserted successfully.")

                ' Get the auto-generated Student ID
                Dim studentId As Integer = CType(cmdStudent.LastInsertedId, Integer)

                ' Insert the selected subjects into the StudentSubjects table
                For Each subjectName As String In selectedSubjects
                    ' Check if the subject already exists
                    Dim queryCheckSubject As String = "SELECT subject_id FROM Subjects WHERE subject_code = @subjectCode"
                    cmdSubject = New MySqlCommand(queryCheckSubject, connection)
                    cmdSubject.Parameters.AddWithValue("@subjectCode", subjectName)

                    Dim subjectId As Object = cmdSubject.ExecuteScalar()

                    ' If the subject exists, insert into StudentSubjects table
                    If subjectId IsNot Nothing Then
                        ' Insert into StudentSubjects table
                        Dim queryStudentSubjects As String = "INSERT INTO StudentSubjects (student_id, subject_id) VALUES (@studentId, @subjectId)"
                        Using cmdStudentSubjects As New MySqlCommand(queryStudentSubjects, connection)
                            cmdStudentSubjects.Parameters.AddWithValue("@studentId", studentId)
                            cmdStudentSubjects.Parameters.AddWithValue("@subjectId", subjectId)
                            cmdStudentSubjects.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Subject inserted successfully: " & subjectName)
                    Else
                        MessageBox.Show("Subject not found: " & subjectName)
                    End If
                Next

                RaiseEvent UserRegistered()
                MessageBox.Show("User and subjects registered successfully!")
                ' Optionally clear the form fields after registration
                ClearForm()

            Catch ex As MySqlException
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub ClearForm()
        ' Clear all the input fields
        fullname_tb.Clear()
        gender_cb.SelectedIndex = -1
        contact_tb.Clear()
        department_cb.SelectedIndex = -1
        subject_clb.ClearSelected()
        username_tb.Clear()
        password_tb.Clear()
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub department_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles department_cb.SelectedIndexChanged

    End Sub
End Class
