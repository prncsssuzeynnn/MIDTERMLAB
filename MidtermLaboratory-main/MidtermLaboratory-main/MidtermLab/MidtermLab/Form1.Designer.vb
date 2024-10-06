<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        user_table = New DataGridView()
        user_id = New DataGridViewTextBoxColumn()
        user_username = New DataGridViewTextBoxColumn()
        user_password = New DataGridViewTextBoxColumn()
        user_usertype = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        createadmin_btn = New Button()
        subjectsetgrade_btn = New Button()
        subjects_btn = New Button()
        createstudent_btn = New Button()
        grade_btn = New Button()
        createsubject_btn = New Button()
        studentinfo_btn = New Button()
        addgrades_btn = New Button()
        user_btn = New Button()
        studentinfo_table = New DataGridView()
        student_id = New DataGridViewTextBoxColumn()
        student_name = New DataGridViewTextBoxColumn()
        student_gender = New DataGridViewTextBoxColumn()
        student_contact = New DataGridViewTextBoxColumn()
        student_department = New DataGridViewTextBoxColumn()
        student_accid = New DataGridViewTextBoxColumn()
        grade_table = New DataGridView()
        grade_gradeid = New DataGridViewTextBoxColumn()
        grade_studentid = New DataGridViewTextBoxColumn()
        grade_midtermgrade = New DataGridViewTextBoxColumn()
        grade_finalgrade = New DataGridViewTextBoxColumn()
        grade_average = New DataGridViewTextBoxColumn()
        grade_remarks = New DataGridViewTextBoxColumn()
        subject_table = New DataGridView()
        subject_subjectid = New DataGridViewTextBoxColumn()
        subject_subjectcode = New DataGridViewTextBoxColumn()
        subject_subjectname = New DataGridViewTextBoxColumn()
        subjectset_table = New DataGridView()
        set_setid = New DataGridViewTextBoxColumn()
        set_studentid = New DataGridViewTextBoxColumn()
        set_subjectid = New DataGridViewTextBoxColumn()
        set_midgrade = New DataGridViewTextBoxColumn()
        set_fingrade = New DataGridViewTextBoxColumn()
        CType(user_table, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(studentinfo_table, ComponentModel.ISupportInitialize).BeginInit()
        CType(grade_table, ComponentModel.ISupportInitialize).BeginInit()
        CType(subject_table, ComponentModel.ISupportInitialize).BeginInit()
        CType(subjectset_table, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' user_table
        ' 
        user_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        user_table.Columns.AddRange(New DataGridViewColumn() {user_id, user_username, user_password, user_usertype})
        user_table.Location = New Point(161, 63)
        user_table.Name = "user_table"
        user_table.RowHeadersVisible = False
        user_table.Size = New Size(803, 334)
        user_table.TabIndex = 0
        ' 
        ' user_id
        ' 
        user_id.HeaderText = "Account ID"
        user_id.Name = "user_id"
        ' 
        ' user_username
        ' 
        user_username.HeaderText = "Username"
        user_username.Name = "user_username"
        user_username.Width = 250
        ' 
        ' user_password
        ' 
        user_password.HeaderText = "Password"
        user_password.Name = "user_password"
        user_password.Width = 250
        ' 
        ' user_usertype
        ' 
        user_usertype.HeaderText = "User Type"
        user_usertype.Name = "user_usertype"
        user_usertype.Width = 200
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(161, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 25)
        Label1.TabIndex = 1
        Label1.Text = "Admin Dashboard"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.Location = New Point(927, 418)
        Button1.Name = "Button1"
        Button1.Size = New Size(37, 26)
        Button1.TabIndex = 2
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.Controls.Add(createadmin_btn)
        Panel1.Controls.Add(subjectsetgrade_btn)
        Panel1.Controls.Add(subjects_btn)
        Panel1.Controls.Add(createstudent_btn)
        Panel1.Controls.Add(grade_btn)
        Panel1.Controls.Add(createsubject_btn)
        Panel1.Controls.Add(studentinfo_btn)
        Panel1.Controls.Add(addgrades_btn)
        Panel1.Controls.Add(user_btn)
        Panel1.Location = New Point(12, 63)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(126, 334)
        Panel1.TabIndex = 3
        ' 
        ' createadmin_btn
        ' 
        createadmin_btn.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        createadmin_btn.Cursor = Cursors.Hand
        createadmin_btn.ForeColor = Color.White
        createadmin_btn.Location = New Point(3, 248)
        createadmin_btn.Name = "createadmin_btn"
        createadmin_btn.Size = New Size(120, 36)
        createadmin_btn.TabIndex = 11
        createadmin_btn.Text = "Add Admin"
        createadmin_btn.UseVisualStyleBackColor = False
        ' 
        ' subjectsetgrade_btn
        ' 
        subjectsetgrade_btn.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        subjectsetgrade_btn.Cursor = Cursors.Hand
        subjectsetgrade_btn.ForeColor = Color.White
        subjectsetgrade_btn.Location = New Point(3, 150)
        subjectsetgrade_btn.Name = "subjectsetgrade_btn"
        subjectsetgrade_btn.Size = New Size(118, 43)
        subjectsetgrade_btn.TabIndex = 4
        subjectsetgrade_btn.Text = "Subject Grades"
        subjectsetgrade_btn.UseVisualStyleBackColor = False
        ' 
        ' subjects_btn
        ' 
        subjects_btn.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        subjects_btn.Cursor = Cursors.Hand
        subjects_btn.ForeColor = Color.White
        subjects_btn.Location = New Point(3, 199)
        subjects_btn.Name = "subjects_btn"
        subjects_btn.Size = New Size(118, 43)
        subjects_btn.TabIndex = 3
        subjects_btn.Text = "Subjects"
        subjects_btn.UseVisualStyleBackColor = False
        ' 
        ' createstudent_btn
        ' 
        createstudent_btn.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        createstudent_btn.Cursor = Cursors.Hand
        createstudent_btn.ForeColor = Color.White
        createstudent_btn.Location = New Point(3, 287)
        createstudent_btn.Name = "createstudent_btn"
        createstudent_btn.Size = New Size(118, 36)
        createstudent_btn.TabIndex = 7
        createstudent_btn.Text = "Add Student"
        createstudent_btn.UseVisualStyleBackColor = False
        ' 
        ' grade_btn
        ' 
        grade_btn.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        grade_btn.Cursor = Cursors.Hand
        grade_btn.ForeColor = Color.White
        grade_btn.Location = New Point(3, 101)
        grade_btn.Name = "grade_btn"
        grade_btn.Size = New Size(118, 43)
        grade_btn.TabIndex = 2
        grade_btn.Text = "Grade"
        grade_btn.UseVisualStyleBackColor = False
        ' 
        ' createsubject_btn
        ' 
        createsubject_btn.Location = New Point(3, 288)
        createsubject_btn.Name = "createsubject_btn"
        createsubject_btn.Size = New Size(118, 36)
        createsubject_btn.TabIndex = 8
        createsubject_btn.Text = "Create Subject"
        createsubject_btn.UseVisualStyleBackColor = True
        ' 
        ' studentinfo_btn
        ' 
        studentinfo_btn.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        studentinfo_btn.Cursor = Cursors.Hand
        studentinfo_btn.ForeColor = Color.White
        studentinfo_btn.Location = New Point(3, 52)
        studentinfo_btn.Name = "studentinfo_btn"
        studentinfo_btn.Size = New Size(118, 43)
        studentinfo_btn.TabIndex = 1
        studentinfo_btn.Text = "Student Info."
        studentinfo_btn.UseVisualStyleBackColor = False
        ' 
        ' addgrades_btn
        ' 
        addgrades_btn.Location = New Point(3, 290)
        addgrades_btn.Name = "addgrades_btn"
        addgrades_btn.Size = New Size(118, 33)
        addgrades_btn.TabIndex = 9
        addgrades_btn.Text = "Add Grades"
        addgrades_btn.UseVisualStyleBackColor = True
        ' 
        ' user_btn
        ' 
        user_btn.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        user_btn.Cursor = Cursors.Hand
        user_btn.ForeColor = Color.White
        user_btn.Location = New Point(3, 3)
        user_btn.Name = "user_btn"
        user_btn.Size = New Size(118, 43)
        user_btn.TabIndex = 0
        user_btn.Text = "User Account"
        user_btn.UseVisualStyleBackColor = False
        ' 
        ' studentinfo_table
        ' 
        studentinfo_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        studentinfo_table.Columns.AddRange(New DataGridViewColumn() {student_id, student_name, student_gender, student_contact, student_department, student_accid})
        studentinfo_table.Location = New Point(161, 63)
        studentinfo_table.Name = "studentinfo_table"
        studentinfo_table.RowHeadersVisible = False
        studentinfo_table.Size = New Size(803, 334)
        studentinfo_table.TabIndex = 4
        studentinfo_table.Visible = False
        ' 
        ' student_id
        ' 
        student_id.HeaderText = "Student ID"
        student_id.Name = "student_id"
        student_id.Width = 80
        ' 
        ' student_name
        ' 
        student_name.HeaderText = "Student Name"
        student_name.Name = "student_name"
        student_name.Width = 230
        ' 
        ' student_gender
        ' 
        student_gender.HeaderText = "Gender"
        student_gender.Name = "student_gender"
        student_gender.Width = 80
        ' 
        ' student_contact
        ' 
        student_contact.HeaderText = "Contact Number"
        student_contact.Name = "student_contact"
        student_contact.Width = 140
        ' 
        ' student_department
        ' 
        student_department.HeaderText = "Department"
        student_department.Name = "student_department"
        student_department.Resizable = DataGridViewTriState.True
        student_department.SortMode = DataGridViewColumnSortMode.NotSortable
        student_department.Width = 200
        ' 
        ' student_accid
        ' 
        student_accid.HeaderText = "Account ID"
        student_accid.Name = "student_accid"
        student_accid.Width = 70
        ' 
        ' grade_table
        ' 
        grade_table.AllowUserToResizeColumns = False
        grade_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grade_table.Columns.AddRange(New DataGridViewColumn() {grade_gradeid, grade_studentid, grade_midtermgrade, grade_finalgrade, grade_average, grade_remarks})
        grade_table.Location = New Point(161, 63)
        grade_table.Name = "grade_table"
        grade_table.RowHeadersVisible = False
        grade_table.Size = New Size(803, 334)
        grade_table.TabIndex = 5
        ' 
        ' grade_gradeid
        ' 
        grade_gradeid.HeaderText = "Grade ID"
        grade_gradeid.Name = "grade_gradeid"
        ' 
        ' grade_studentid
        ' 
        grade_studentid.HeaderText = "Student Name"
        grade_studentid.Name = "grade_studentid"
        grade_studentid.Width = 250
        ' 
        ' grade_midtermgrade
        ' 
        grade_midtermgrade.HeaderText = "Midterm Grade"
        grade_midtermgrade.Name = "grade_midtermgrade"
        ' 
        ' grade_finalgrade
        ' 
        grade_finalgrade.HeaderText = "Final Grade"
        grade_finalgrade.Name = "grade_finalgrade"
        ' 
        ' grade_average
        ' 
        grade_average.HeaderText = "Average"
        grade_average.Name = "grade_average"
        ' 
        ' grade_remarks
        ' 
        grade_remarks.HeaderText = "Remarks"
        grade_remarks.Name = "grade_remarks"
        grade_remarks.Width = 150
        ' 
        ' subject_table
        ' 
        subject_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        subject_table.Columns.AddRange(New DataGridViewColumn() {subject_subjectid, subject_subjectcode, subject_subjectname})
        subject_table.Location = New Point(161, 63)
        subject_table.Name = "subject_table"
        subject_table.RowHeadersVisible = False
        subject_table.Size = New Size(803, 334)
        subject_table.TabIndex = 6
        ' 
        ' subject_subjectid
        ' 
        subject_subjectid.HeaderText = "Subject ID"
        subject_subjectid.Name = "subject_subjectid"
        subject_subjectid.Width = 200
        ' 
        ' subject_subjectcode
        ' 
        subject_subjectcode.HeaderText = "Subject Code"
        subject_subjectcode.Name = "subject_subjectcode"
        subject_subjectcode.Width = 200
        ' 
        ' subject_subjectname
        ' 
        subject_subjectname.HeaderText = "Subject Name"
        subject_subjectname.Name = "subject_subjectname"
        subject_subjectname.Width = 400
        ' 
        ' subjectset_table
        ' 
        subjectset_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        subjectset_table.Columns.AddRange(New DataGridViewColumn() {set_setid, set_studentid, set_subjectid, set_midgrade, set_fingrade})
        subjectset_table.Location = New Point(161, 63)
        subjectset_table.Name = "subjectset_table"
        subjectset_table.RowHeadersVisible = False
        subjectset_table.Size = New Size(803, 334)
        subjectset_table.TabIndex = 10
        ' 
        ' set_setid
        ' 
        set_setid.HeaderText = "Set Id"
        set_setid.Name = "set_setid"
        set_setid.Width = 160
        ' 
        ' set_studentid
        ' 
        set_studentid.HeaderText = "Student Id"
        set_studentid.Name = "set_studentid"
        set_studentid.Width = 170
        ' 
        ' set_subjectid
        ' 
        set_subjectid.HeaderText = "Subject Id"
        set_subjectid.Name = "set_subjectid"
        set_subjectid.Width = 170
        ' 
        ' set_midgrade
        ' 
        set_midgrade.HeaderText = "Midterm Grade"
        set_midgrade.Name = "set_midgrade"
        set_midgrade.Width = 150
        ' 
        ' set_fingrade
        ' 
        set_fingrade.HeaderText = "Final Grade"
        set_fingrade.Name = "set_fingrade"
        set_fingrade.Width = 150
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(976, 456)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(user_table)
        Controls.Add(subject_table)
        Controls.Add(grade_table)
        Controls.Add(studentinfo_table)
        Controls.Add(subjectset_table)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMIN DASHBOARD"
        CType(user_table, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(studentinfo_table, ComponentModel.ISupportInitialize).EndInit()
        CType(grade_table, ComponentModel.ISupportInitialize).EndInit()
        CType(subject_table, ComponentModel.ISupportInitialize).EndInit()
        CType(subjectset_table, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents user_table As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents subjects_btn As Button
    Friend WithEvents grade_btn As Button
    Friend WithEvents studentinfo_btn As Button
    Friend WithEvents user_btn As Button
    Friend WithEvents studentinfo_table As DataGridView
    Friend WithEvents grade_table As DataGridView
    Friend WithEvents subject_table As DataGridView
    Friend WithEvents user_id As DataGridViewTextBoxColumn
    Friend WithEvents user_username As DataGridViewTextBoxColumn
    Friend WithEvents user_password As DataGridViewTextBoxColumn
    Friend WithEvents user_usertype As DataGridViewTextBoxColumn
    Friend WithEvents createstudent_btn As Button
    Friend WithEvents createsubject_btn As Button
    Friend WithEvents subject_subjectid As DataGridViewTextBoxColumn
    Friend WithEvents subject_subjectcode As DataGridViewTextBoxColumn
    Friend WithEvents subject_subjectname As DataGridViewTextBoxColumn
    Friend WithEvents addgrades_btn As Button
    Friend WithEvents student_id As DataGridViewTextBoxColumn
    Friend WithEvents student_name As DataGridViewTextBoxColumn
    Friend WithEvents student_gender As DataGridViewTextBoxColumn
    Friend WithEvents student_contact As DataGridViewTextBoxColumn
    Friend WithEvents student_department As DataGridViewTextBoxColumn
    Friend WithEvents student_accid As DataGridViewTextBoxColumn
    Friend WithEvents grade_gradeid As DataGridViewTextBoxColumn
    Friend WithEvents grade_studentid As DataGridViewTextBoxColumn
    Friend WithEvents grade_midtermgrade As DataGridViewTextBoxColumn
    Friend WithEvents grade_finalgrade As DataGridViewTextBoxColumn
    Friend WithEvents grade_average As DataGridViewTextBoxColumn
    Friend WithEvents grade_remarks As DataGridViewTextBoxColumn
    Friend WithEvents subjectsetgrade_btn As Button
    Friend WithEvents subjectset_table As DataGridView
    Friend WithEvents set_setid As DataGridViewTextBoxColumn
    Friend WithEvents set_studentid As DataGridViewTextBoxColumn
    Friend WithEvents set_subjectid As DataGridViewTextBoxColumn
    Friend WithEvents set_midgrade As DataGridViewTextBoxColumn
    Friend WithEvents set_fingrade As DataGridViewTextBoxColumn
    Friend WithEvents createadmin_btn As Button

End Class
