Imports MySql.Data.MySqlClient

Public Class Add_Grades
    Private connectionString As String = "Server=localhost;Database=midtermlab_db;Uid=root;Pwd=;"
    Public Event AddGrades()
    Private Sub AddGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
        LoadSubjects()
    End Sub

    Private Sub LoadStudents()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Define the query to fetch student names and IDs
                Dim query As String = "SELECT student_id, name FROM Students"
                Dim command As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Clear existing items (if any) in the ComboBox
                studentnames_cb.Items.Clear()

                ' Load the student names into the ComboBox
                While reader.Read()
                    studentnames_cb.Items.Add(New With {
                        .Text = reader("name").ToString(),
                        .Value = reader("student_id").ToString()
                    })
                End While

                ' Set the DisplayMember and ValueMember properties
                studentnames_cb.DisplayMember = "Text"
                studentnames_cb.ValueMember = "Value"

            Catch ex As MySqlException
                MessageBox.Show("Error loading students: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadSubjects()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Define the query to fetch subject codes
                Dim query As String = "SELECT subject_code FROM Subjects"
                Dim command As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Clear existing items (if any) in the CheckedListBox
                subjects_clb.Items.Clear()

                ' Load the subjects into the CheckedListBox
                While reader.Read()
                    Dim subjectCode As String = reader("subject_code").ToString()
                    subjects_clb.Items.Add(subjectCode) ' Add subject codes to the CheckedListBox
                End While
            Catch ex As MySqlException
                MessageBox.Show("Error loading subjects: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Event handler for when the selected student changes
    Private Sub studentnames_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studentnames_cb.SelectedIndexChanged
        If studentnames_cb.SelectedItem IsNot Nothing Then
            ' Use Object type and cast to access the properties
            Dim selectedStudent As Object = studentnames_cb.SelectedItem
            Dim studentId As Integer = Convert.ToInt32(selectedStudent.GetType().GetProperty("Value").GetValue(selectedStudent, Nothing))
            LoadStudentSubjects(studentId) ' Pass the student ID
        End If
    End Sub

    ' Method to load subjects based on selected student
    Private Sub LoadStudentSubjects(studentId As Integer)
        ' Clear existing items in the ListView
        subjects_clb.Items.Clear()
        ' Clear existing text in the labels
        subject1_lbl.Text = ""
        subject2_lbl.Text = ""
        subject3_lbl.Text = ""
        subject4_lbl.Text = ""
        subject5_lbl.Text = ""

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Fetch the subject IDs associated with the selected student
                Dim query As String = "SELECT subject_id FROM StudentSubjects WHERE student_id = @studentId"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@studentId", studentId)

                Dim subjectIds As New List(Of Integer)()

                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        subjectIds.Add(reader("subject_id"))
                    End While
                End Using

                ' Populate the ListView with subject names based on the subject IDs
                For Each subjectId In subjectIds
                    Dim querySubject As String = "SELECT subject_code FROM Subjects WHERE subject_id = @subjectId"
                    Dim commandSubject As New MySqlCommand(querySubject, connection)
                    commandSubject.Parameters.AddWithValue("@subjectId", subjectId)

                    Dim subjectCode As String = commandSubject.ExecuteScalar()?.ToString()
                    If subjectCode IsNot Nothing Then
                        ' Add the subject code to the ListView
                        subjects_clb.Items.Add(subjectCode)
                    End If
                Next

                ' Populate labels based on the ListView items
                If subjects_clb.Items.Count > 0 Then subject1_lbl.Text = subjects_clb.Items(0).ToString()
                If subjects_clb.Items.Count > 1 Then subject2_lbl.Text = subjects_clb.Items(1).ToString()
                If subjects_clb.Items.Count > 2 Then subject3_lbl.Text = subjects_clb.Items(2).ToString()
                If subjects_clb.Items.Count > 3 Then subject4_lbl.Text = subjects_clb.Items(3).ToString()
                If subjects_clb.Items.Count > 4 Then subject5_lbl.Text = subjects_clb.Items(4).ToString()

            Catch ex As MySqlException
                MessageBox.Show("Error loading subjects for the selected student: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub submit_btn_Click(sender As Object, e As EventArgs) Handles submit_btn.Click
        ' Check if a student is selected
        If studentnames_cb.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a student.")
            Return
        End If

        ' Get the selected student ID
        Dim selectedStudent As Object = studentnames_cb.SelectedItem
        Dim studentId As Integer = Convert.ToInt32(selectedStudent.GetType().GetProperty("Value").GetValue(selectedStudent, Nothing))

        ' Prepare to capture grades
        Dim midtermGrades As New List(Of Double)
        Dim finalGrades As New List(Of Double)

        ' Read the midterm and final grades from the TextBoxes
        Dim midtermInputs() As TextBox = {midsubject1_tb, midsubject2_tb, midsubject3_tb, midsubject4_tb, midsubject5_tb}
        Dim finalInputs() As TextBox = {finsubject1_tb, finsubject2_tb, finsubject3_tb, finsubject4_tb, finsubject5_tb}

        ' Collect midterm grades
        For Each tb As TextBox In midtermInputs
            Dim grade As Double
            If Double.TryParse(tb.Text, grade) Then
                midtermGrades.Add(grade)
            End If
        Next

        ' Collect final grades
        For Each tb As TextBox In finalInputs
            Dim grade As Double
            If Double.TryParse(tb.Text, grade) Then
                finalGrades.Add(grade)
            End If
        Next

        ' Insert the grades into the subject_initialgrade table based on the selected subjects in the ListBox
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            For i As Integer = 0 To subjects_clb.Items.Count - 1
                Dim subjectCode As String = subjects_clb.Items(i).ToString() ' Get the subject code from the ListBox

                ' Fetch the subject_id based on the subject code
                Dim subjectIdQuery As String = "SELECT subject_id FROM Subjects WHERE subject_code = @subjectCode"
                Using command As New MySqlCommand(subjectIdQuery, connection)
                    command.Parameters.AddWithValue("@subjectCode", subjectCode)
                    Dim subjectId As Object = command.ExecuteScalar() ' Get the subject ID

                    If subjectId IsNot Nothing Then
                        Dim midtermGrade As Double = If(i < midtermGrades.Count, midtermGrades(i), 0) ' Get midterm grade
                        Dim finalGrade As Double = If(i < finalGrades.Count, finalGrades(i), 0) ' Get final grade

                        ' Prepare the SQL insert query
                        Dim query As String = "INSERT INTO subject_initialgrade (student_id, subject_id, midterm_grade, final_grade) " &
                                          "VALUES (@studentId, @subjectId, @midtermGrade, @finalGrade)"
                        Using insertCommand As New MySqlCommand(query, connection)
                            insertCommand.Parameters.AddWithValue("@studentId", studentId)
                            insertCommand.Parameters.AddWithValue("@subjectId", Convert.ToInt32(subjectId))
                            insertCommand.Parameters.AddWithValue("@midtermGrade", midtermGrade)
                            insertCommand.Parameters.AddWithValue("@finalGrade", finalGrade)

                            RaiseEvent AddGrades()
                            Try
                                insertCommand.ExecuteNonQuery()
                            Catch ex As MySqlException
                                MessageBox.Show("Error saving subject grades: " & ex.Message)
                            End Try
                        End Using
                    End If
                End Using
            Next
        End Using

        MessageBox.Show("Grades have been successfully recorded!")
        Me.Close()
    End Sub



    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles final_rst.Click

    End Sub

    Private Sub calculate_btn_Click(sender As Object, e As EventArgs) Handles calculate_btn.Click
        ' Initialize variables to store the midterm and final grades
        Dim midtermGrades As New List(Of Double)
        Dim finalGrades As New List(Of Double)

        ' Read the midterm grades from the text boxes
        Dim midtermInputs() As TextBox = {midsubject1_tb, midsubject2_tb, midsubject3_tb, midsubject4_tb, midsubject5_tb}
        For Each tb As TextBox In midtermInputs
            Dim grade As Double
            If Double.TryParse(tb.Text, grade) Then
                midtermGrades.Add(grade)
            End If
        Next

        ' Calculate the midterm average
        Dim midtermcompute As Double = If(midtermGrades.Count > 0, midtermGrades.Average(), 0)
        midterm_rst.Text = midtermcompute.ToString("F2") ' Display the midterm average in the result textbox

        ' Read the final grades from the text boxes
        Dim finalInputs() As TextBox = {finsubject1_tb, finsubject2_tb, finsubject3_tb, finsubject4_tb, finsubject5_tb}
        For Each tb As TextBox In finalInputs
            Dim grade As Double
            If Double.TryParse(tb.Text, grade) Then
                finalGrades.Add(grade)
            End If
        Next

        ' Calculate the final average
        Dim finalcompute As Double = If(finalGrades.Count > 0, finalGrades.Average(), 0)
        final_rst.Text = finalcompute.ToString("F2") ' Display the final average in the result textbox

        ' Calculate overall average of midterm and final
        Dim overallAverage As Double = (midtermcompute + finalcompute) / 2
        average_rst.Text = overallAverage.ToString("F2") ' Display the overall average in the result textbox

        ' Determine the remarks based on the overall average
        If overallAverage = 0 Then
            remarks_rst.Text = "UD" ' Unofficially Dropout if no grades were entered
        ElseIf overallAverage < 75 Then
            remarks_rst.Text = "FAILED"
        ElseIf overallAverage >= 75 Then
            remarks_rst.Text = "PASSED"
        End If

        ' Check for UD if there are no grades entered
        If midtermGrades.Count = 0 AndAlso finalGrades.Count = 0 Then
            remarks_rst.Text = "UD" ' Unofficially Dropout
        End If
    End Sub

    Private Sub subjects_clb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subjects_clb.SelectedIndexChanged

    End Sub
End Class