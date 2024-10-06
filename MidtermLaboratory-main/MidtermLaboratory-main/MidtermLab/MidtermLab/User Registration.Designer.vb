<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Registration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Registration))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        department_cb = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        Label8 = New Label()
        subject_clb = New CheckedListBox()
        submit_btn = New Button()
        back_btn = New Button()
        fullname_tb = New TextBox()
        contact_tb = New TextBox()
        gender_cb = New ComboBox()
        Label6 = New Label()
        Label7 = New Label()
        username_tb = New TextBox()
        password_tb = New TextBox()
        repassword_tb = New TextBox()
        Label9 = New Label()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 0
        Label1.Text = "Full Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(319, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 1
        Label2.Text = "Gender:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(457, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 15)
        Label3.TabIndex = 2
        Label3.Text = "Contact Number: "
        ' 
        ' department_cb
        ' 
        department_cb.FormattingEnabled = True
        department_cb.Items.AddRange(New Object() {"ENGINEERING", "INFORMATION TECHNOLOGY", "COMPUTER SCIENCE", "INFORMATION SYSTEM"})
        department_cb.Location = New Point(481, 204)
        department_cb.Name = "department_cb"
        department_cb.Size = New Size(219, 23)
        department_cb.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(347, 204)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 15)
        Label4.TabIndex = 4
        Label4.Text = "Assigned Department:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(350, 253)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 15)
        Label5.TabIndex = 5
        Label5.Text = "Assigned Subjects:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(297, 24)
        Label8.Name = "Label8"
        Label8.Size = New Size(154, 24)
        Label8.TabIndex = 8
        Label8.Text = "Student Account "
        ' 
        ' subject_clb
        ' 
        subject_clb.FormattingEnabled = True
        subject_clb.Items.AddRange(New Object() {"SAD", "CC104", "PF101", "IM101", "NET101", "FIL", "PE"})
        subject_clb.Location = New Point(481, 253)
        subject_clb.Name = "subject_clb"
        subject_clb.Size = New Size(133, 68)
        subject_clb.TabIndex = 9
        ' 
        ' submit_btn
        ' 
        submit_btn.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        submit_btn.Cursor = Cursors.Hand
        submit_btn.ForeColor = Color.White
        submit_btn.Location = New Point(246, 372)
        submit_btn.Name = "submit_btn"
        submit_btn.Size = New Size(79, 23)
        submit_btn.TabIndex = 10
        submit_btn.Text = "SUBMIT"
        submit_btn.UseVisualStyleBackColor = False
        ' 
        ' back_btn
        ' 
        back_btn.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        back_btn.Cursor = Cursors.Hand
        back_btn.ForeColor = Color.White
        back_btn.Location = New Point(424, 372)
        back_btn.Name = "back_btn"
        back_btn.Size = New Size(75, 23)
        back_btn.TabIndex = 11
        back_btn.Text = "BACK"
        back_btn.UseVisualStyleBackColor = False
        ' 
        ' fullname_tb
        ' 
        fullname_tb.Location = New Point(79, 43)
        fullname_tb.Name = "fullname_tb"
        fullname_tb.Size = New Size(234, 21)
        fullname_tb.TabIndex = 13
        ' 
        ' contact_tb
        ' 
        contact_tb.Location = New Point(562, 41)
        contact_tb.Name = "contact_tb"
        contact_tb.Size = New Size(125, 21)
        contact_tb.TabIndex = 15
        ' 
        ' gender_cb
        ' 
        gender_cb.FormattingEnabled = True
        gender_cb.Items.AddRange(New Object() {"MALE", "FEMALE", "OTHER"})
        gender_cb.Location = New Point(376, 40)
        gender_cb.Name = "gender_cb"
        gender_cb.Size = New Size(72, 23)
        gender_cb.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Location = New Point(26, 247)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 15)
        Label6.TabIndex = 6
        Label6.Text = "Password:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Location = New Point(26, 201)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 15)
        Label7.TabIndex = 7
        Label7.Text = "Username:"
        ' 
        ' username_tb
        ' 
        username_tb.Location = New Point(100, 201)
        username_tb.Name = "username_tb"
        username_tb.Size = New Size(225, 21)
        username_tb.TabIndex = 17
        ' 
        ' password_tb
        ' 
        password_tb.Location = New Point(100, 247)
        password_tb.Name = "password_tb"
        password_tb.PasswordChar = "*"c
        password_tb.Size = New Size(225, 21)
        password_tb.TabIndex = 18
        ' 
        ' repassword_tb
        ' 
        repassword_tb.Location = New Point(121, 294)
        repassword_tb.Name = "repassword_tb"
        repassword_tb.PasswordChar = "*"c
        repassword_tb.Size = New Size(204, 21)
        repassword_tb.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Location = New Point(26, 297)
        Label9.Name = "Label9"
        Label9.Size = New Size(84, 15)
        Label9.TabIndex = 20
        Label9.Text = "Re-Password:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(fullname_tb)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(gender_cb)
        GroupBox1.Controls.Add(contact_tb)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.ForeColor = SystemColors.ActiveCaptionText
        GroupBox1.Location = New Point(12, 69)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(717, 100)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "PERSONAL INFORMATION"
        ' 
        ' User_Registration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(741, 420)
        ControlBox = False
        Controls.Add(Label9)
        Controls.Add(repassword_tb)
        Controls.Add(password_tb)
        Controls.Add(username_tb)
        Controls.Add(back_btn)
        Controls.Add(submit_btn)
        Controls.Add(subject_clb)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(department_cb)
        Controls.Add(GroupBox1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "User_Registration"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User_Registration"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents department_cb As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents subject_clb As CheckedListBox
    Friend WithEvents submit_btn As Button
    Friend WithEvents back_btn As Button
    Friend WithEvents fullname_tb As TextBox
    Friend WithEvents contact_tb As TextBox
    Friend WithEvents gender_cb As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents username_tb As TextBox
    Friend WithEvents password_tb As TextBox
    Friend WithEvents repassword_tb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
