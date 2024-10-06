Imports MySql.Data.MySqlClient

Public Class Form1
    Private connectionString As String = "Server=localhost;Database=midtermlab_db;Uid=root;Pwd=;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user_table.Visible = True ' Ensure DataGridView is visible
        createsubject_btn.Visible = False
        LoadUserData()
    End Sub

    Private Sub LoadUserData()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "SELECT user_id, username AS user_username, password AS user_password, user_type AS user_usertype FROM Users"

                Dim adapter As New MySqlDataAdapter(query, connection)

                Dim table As New DataTable()
                adapter.Fill(table)

                user_table.AutoGenerateColumns = False
                user_table.Columns("user_id").DataPropertyName = "user_id"
                user_table.Columns("user_username").DataPropertyName = "user_username"
                user_table.Columns("user_password").DataPropertyName = "user_password"
                user_table.Columns("user_usertype").DataPropertyName = "user_usertype"

                user_table.DataSource = table

            Catch ex As MySqlException
                MessageBox.Show("Error fetching user data: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub LoadStudentData()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Corrected query to ensure proper column mapping
                Dim query As String = "SELECT student_id, name AS student_name, gender AS student_gender, contact_number AS student_contact, department AS student_department, user_id FROM students"

                Dim adapter As New MySqlDataAdapter(query, connection)

                Dim table As New DataTable()
                adapter.Fill(table)

                studentinfo_table.AutoGenerateColumns = False
                studentinfo_table.Columns("student_id").DataPropertyName = "student_id"
                studentinfo_table.Columns("student_name").DataPropertyName = "student_name"
                studentinfo_table.Columns("student_gender").DataPropertyName = "student_gender"
                studentinfo_table.Columns("student_contact").DataPropertyName = "student_contact"
                studentinfo_table.Columns("student_department").DataPropertyName = "student_department"
                studentinfo_table.Columns("student_accid").DataPropertyName = "user_id" ' Correctly bind user_id column
                studentinfo_table.DataSource = table

            Catch ex As MySqlException
                MessageBox.Show("Error fetching student data: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub
    Private Sub LoadSubjectData()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "SELECT subject_id, subject_code AS subject_subjectcode, subject_name AS subject_subjectname FROM subjects"

                Dim adapter As New MySqlDataAdapter(query, connection)

                Dim table As New DataTable()
                adapter.Fill(table)

                subject_table.AutoGenerateColumns = False
                subject_table.Columns("subject_subjectid").DataPropertyName = "subject_id"
                subject_table.Columns("subject_subjectcode").DataPropertyName = "subject_subjectcode"
                subject_table.Columns("subject_subjectname").DataPropertyName = "subject_subjectname"

                subject_table.DataSource = table

            Catch ex As MySqlException
                MessageBox.Show("Error fetching subject data: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub LoadGradeData()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Removed subject_id from the SELECT statement
                Dim query As String = "SELECT sg.record_id, s.name AS student_name, sg.midterm_grade, sg.final_grade, sg.overall_grade, sg.status " &
                                  "FROM studentgrades sg " &
                                  "INNER JOIN Students s ON sg.student_id = s.student_id"

                Dim adapter As New MySqlDataAdapter(query, connection)

                Dim table As New DataTable()
                adapter.Fill(table)

                grade_table.AutoGenerateColumns = False
                grade_table.Columns("grade_gradeid").DataPropertyName = "record_id"
                grade_table.Columns("grade_studentid").DataPropertyName = "student_name"
                grade_table.Columns("grade_midtermgrade").DataPropertyName = "midterm_grade"
                grade_table.Columns("grade_finalgrade").DataPropertyName = "final_grade"
                grade_table.Columns("grade_average").DataPropertyName = "overall_grade"
                grade_table.Columns("grade_remarks").DataPropertyName = "status"

                grade_table.DataSource = table

            Catch ex As MySqlException
                MessageBox.Show("Error fetching grade data: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Form1
        frm.Show()
        Me.Close()
    End Sub

    Private Sub user_btn_Click(sender As Object, e As EventArgs) Handles user_btn.Click
        user_table.Visible = True
        createstudent_btn.Visible = True
        studentinfo_table.Visible = False
        grade_table.Visible = False
        subject_table.Visible = False
        subjectset_table.Visible = False
        createsubject_btn.Visible = False
        addgrades_btn.Visible = False
        createadmin_btn.Visible = True
        LoadUserData()
    End Sub

    Private Sub studentinfo_btn_Click(sender As Object, e As EventArgs) Handles studentinfo_btn.Click
        studentinfo_table.Visible = True
        user_table.Visible = False
        grade_table.Visible = False
        subject_table.Visible = False
        createstudent_btn.Visible = False
        createsubject_btn.Visible = False
        addgrades_btn.Visible = False
        createadmin_btn.Visible = False
        subjectset_table.Visible = False
        LoadStudentData()
    End Sub

    Private Sub grade_btn_Click(sender As Object, e As EventArgs) Handles grade_btn.Click
        grade_table.Visible = True
        LoadGradeData()
        user_table.Visible = False
        studentinfo_table.Visible = False
        subject_table.Visible = False
        createstudent_btn.Visible = False
        createsubject_btn.Visible = False
        addgrades_btn.Visible = True
        subjectset_table.Visible = False
        createadmin_btn.Visible = False
    End Sub

    Private Sub subjects_btn_Click(sender As Object, e As EventArgs) Handles subjects_btn.Click
        subject_table.Visible = True
        user_table.Visible = False
        studentinfo_table.Visible = False
        grade_table.Visible = False
        createstudent_btn.Visible = False
        createsubject_btn.Visible = True
        addgrades_btn.Visible = False
        subjectset_table.Visible = False
        createadmin_btn.Visible = False
        LoadSubjectData()
    End Sub

    Private Sub user_table_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles user_table.CellContentClick

    End Sub

    Private Sub createstudent_btn_Click(sender As Object, e As EventArgs) Handles createstudent_btn.Click, Button2.Click
        Dim registrationForm As New User_Registration
        AddHandler registrationForm.UserRegistered, AddressOf LoadUserData
        registrationForm.Show
    End Sub

    Private Sub createsubject_btn_Click(sender As Object, e As EventArgs) Handles createsubject_btn.Click
        Dim createSubjectForm As New CreateSubject()
        AddHandler createSubjectForm.SubjectRegistered, AddressOf LoadSubjectData
        createSubjectForm.Show()
    End Sub

    Private Sub addgrades_btn_Click(sender As Object, e As EventArgs) Handles addgrades_btn.Click
        Dim addgradesForm As New Add_Grades()
        AddHandler addgradesForm.AddGrades, AddressOf LoadGradeData
        addgradesForm.Show()
    End Sub

    Private Sub subjectsetgrade_btn_Click(sender As Object, e As EventArgs) Handles subjectsetgrade_btn.Click
        user_table.Visible = False
        subjectset_table.Visible = True
        grade_table.Visible = False
        studentinfo_table.Visible = False
        createstudent_btn.Visible = False
        addgrades_btn.Visible = False
        subject_table.Visible = False
        createadmin_btn.Visible = False
        LoadSubjectSetData()
    End Sub
    Private Sub LoadSubjectSetData()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "SELECT id, student_id, subject_id,midterm_grade, final_grade FROM subject_initialgrade"

                Dim adapter As New MySqlDataAdapter(query, connection)

                Dim table As New DataTable()
                adapter.Fill(table)

                subjectset_table.AutoGenerateColumns = False

                subjectset_table.Columns("set_setid").DataPropertyName = "id"
                subjectset_table.Columns("set_studentid").DataPropertyName = "student_id"
                subjectset_table.Columns("set_subjectid").DataPropertyName = "subject_id"
                subjectset_table.Columns("set_midgrade").DataPropertyName = "midterm_grade"
                subjectset_table.Columns("set_fingrade").DataPropertyName = "final_grade"

                subjectset_table.DataSource = table

            Catch ex As MySqlException
                MessageBox.Show("Error fetching initial grade data: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub createadmin_btn_Click(sender As Object, e As EventArgs) Handles createadmin_btn.Click
        Dim adminForm As New Admin_Registration()
        AddHandler adminForm.AddAdmin, AddressOf LoadUserData
        adminForm.Show()
    End Sub
End Class
