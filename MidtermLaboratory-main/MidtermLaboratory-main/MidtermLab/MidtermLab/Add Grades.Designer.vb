<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Grades
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Grades))
        Label1 = New Label()
        Label2 = New Label()
        subjects_clb = New ListBox()
        studentnames_cb = New ComboBox()
        submit_btn = New Button()
        BindingSource1 = New BindingSource(components)
        Label3 = New Label()
        Label4 = New Label()
        midsubject1_tb = New TextBox()
        midsubject2_tb = New TextBox()
        midsubject3_tb = New TextBox()
        midsubject4_tb = New TextBox()
        midsubject5_tb = New TextBox()
        finsubject1_tb = New TextBox()
        finsubject2_tb = New TextBox()
        finsubject3_tb = New TextBox()
        finsubject4_tb = New TextBox()
        finsubject5_tb = New TextBox()
        back_btn = New Button()
        subject1_lbl = New Label()
        subject2_lbl = New Label()
        subject3_lbl = New Label()
        subject4_lbl = New Label()
        subject5_lbl = New Label()
        Label5 = New Label()
        midterm_rst = New Label()
        Label7 = New Label()
        final_rst = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Label6 = New Label()
        average_rst = New Label()
        Label9 = New Label()
        remarks_rst = New Label()
        calculate_btn = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(27, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 0
        Label1.Text = "Student Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(27, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 15)
        Label2.TabIndex = 1
        Label2.Text = "Subjects Enrolled: "
        ' 
        ' subjects_clb
        ' 
        subjects_clb.FormattingEnabled = True
        subjects_clb.ItemHeight = 15
        subjects_clb.Items.AddRange(New Object() {"No input......"})
        subjects_clb.Location = New Point(27, 102)
        subjects_clb.Name = "subjects_clb"
        subjects_clb.Size = New Size(266, 154)
        subjects_clb.TabIndex = 2
        ' 
        ' studentnames_cb
        ' 
        studentnames_cb.FormattingEnabled = True
        studentnames_cb.Location = New Point(122, 30)
        studentnames_cb.Name = "studentnames_cb"
        studentnames_cb.Size = New Size(171, 23)
        studentnames_cb.TabIndex = 3
        ' 
        ' submit_btn
        ' 
        submit_btn.BackColor = SystemColors.ScrollBar
        submit_btn.Cursor = Cursors.Hand
        submit_btn.Location = New Point(159, 341)
        submit_btn.Name = "submit_btn"
        submit_btn.Size = New Size(92, 26)
        submit_btn.TabIndex = 4
        submit_btn.Text = "SUBMIT"
        submit_btn.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(124, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 15)
        Label3.TabIndex = 5
        Label3.Text = "Midterm Grade"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(236, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 15)
        Label4.TabIndex = 6
        Label4.Text = "FinalTerm Grade"
        ' 
        ' midsubject1_tb
        ' 
        midsubject1_tb.Location = New Point(128, 59)
        midsubject1_tb.Name = "midsubject1_tb"
        midsubject1_tb.Size = New Size(77, 21)
        midsubject1_tb.TabIndex = 7
        ' 
        ' midsubject2_tb
        ' 
        midsubject2_tb.Location = New Point(128, 94)
        midsubject2_tb.Name = "midsubject2_tb"
        midsubject2_tb.Size = New Size(77, 21)
        midsubject2_tb.TabIndex = 8
        ' 
        ' midsubject3_tb
        ' 
        midsubject3_tb.Location = New Point(128, 127)
        midsubject3_tb.Name = "midsubject3_tb"
        midsubject3_tb.Size = New Size(77, 21)
        midsubject3_tb.TabIndex = 9
        ' 
        ' midsubject4_tb
        ' 
        midsubject4_tb.Location = New Point(128, 168)
        midsubject4_tb.Name = "midsubject4_tb"
        midsubject4_tb.Size = New Size(77, 21)
        midsubject4_tb.TabIndex = 10
        ' 
        ' midsubject5_tb
        ' 
        midsubject5_tb.Location = New Point(128, 206)
        midsubject5_tb.Name = "midsubject5_tb"
        midsubject5_tb.Size = New Size(77, 21)
        midsubject5_tb.TabIndex = 11
        ' 
        ' finsubject1_tb
        ' 
        finsubject1_tb.Location = New Point(244, 59)
        finsubject1_tb.Name = "finsubject1_tb"
        finsubject1_tb.Size = New Size(81, 21)
        finsubject1_tb.TabIndex = 12
        ' 
        ' finsubject2_tb
        ' 
        finsubject2_tb.Location = New Point(244, 94)
        finsubject2_tb.Name = "finsubject2_tb"
        finsubject2_tb.Size = New Size(81, 21)
        finsubject2_tb.TabIndex = 13
        ' 
        ' finsubject3_tb
        ' 
        finsubject3_tb.Location = New Point(244, 127)
        finsubject3_tb.Name = "finsubject3_tb"
        finsubject3_tb.Size = New Size(81, 21)
        finsubject3_tb.TabIndex = 14
        ' 
        ' finsubject4_tb
        ' 
        finsubject4_tb.Location = New Point(244, 168)
        finsubject4_tb.Name = "finsubject4_tb"
        finsubject4_tb.Size = New Size(81, 21)
        finsubject4_tb.TabIndex = 15
        ' 
        ' finsubject5_tb
        ' 
        finsubject5_tb.Location = New Point(244, 206)
        finsubject5_tb.Name = "finsubject5_tb"
        finsubject5_tb.Size = New Size(81, 21)
        finsubject5_tb.TabIndex = 16
        ' 
        ' back_btn
        ' 
        back_btn.BackColor = SystemColors.ControlLight
        back_btn.BackgroundImage = CType(resources.GetObject("back_btn.BackgroundImage"), Image)
        back_btn.BackgroundImageLayout = ImageLayout.Stretch
        back_btn.Cursor = Cursors.Hand
        back_btn.Location = New Point(642, 347)
        back_btn.Name = "back_btn"
        back_btn.Size = New Size(37, 26)
        back_btn.TabIndex = 17
        back_btn.UseVisualStyleBackColor = False
        ' 
        ' subject1_lbl
        ' 
        subject1_lbl.AutoSize = True
        subject1_lbl.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        subject1_lbl.ForeColor = Color.White
        subject1_lbl.Location = New Point(25, 59)
        subject1_lbl.Name = "subject1_lbl"
        subject1_lbl.Size = New Size(55, 15)
        subject1_lbl.TabIndex = 18
        subject1_lbl.Text = "Subject1"
        ' 
        ' subject2_lbl
        ' 
        subject2_lbl.AutoSize = True
        subject2_lbl.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        subject2_lbl.ForeColor = Color.White
        subject2_lbl.Location = New Point(25, 94)
        subject2_lbl.Name = "subject2_lbl"
        subject2_lbl.Size = New Size(55, 15)
        subject2_lbl.TabIndex = 19
        subject2_lbl.Text = "Subject2"
        ' 
        ' subject3_lbl
        ' 
        subject3_lbl.AutoSize = True
        subject3_lbl.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        subject3_lbl.ForeColor = Color.White
        subject3_lbl.Location = New Point(25, 133)
        subject3_lbl.Name = "subject3_lbl"
        subject3_lbl.Size = New Size(55, 15)
        subject3_lbl.TabIndex = 20
        subject3_lbl.Text = "Subject3"
        ' 
        ' subject4_lbl
        ' 
        subject4_lbl.AutoSize = True
        subject4_lbl.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        subject4_lbl.ForeColor = Color.White
        subject4_lbl.Location = New Point(25, 168)
        subject4_lbl.Name = "subject4_lbl"
        subject4_lbl.Size = New Size(55, 15)
        subject4_lbl.TabIndex = 21
        subject4_lbl.Text = "Subject4"
        ' 
        ' subject5_lbl
        ' 
        subject5_lbl.AutoSize = True
        subject5_lbl.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        subject5_lbl.ForeColor = Color.White
        subject5_lbl.Location = New Point(25, 206)
        subject5_lbl.Name = "subject5_lbl"
        subject5_lbl.Size = New Size(55, 15)
        subject5_lbl.TabIndex = 22
        subject5_lbl.Text = "Subject5"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(334, 270)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 15)
        Label5.TabIndex = 23
        Label5.Text = "Midterm Grade:"
        ' 
        ' midterm_rst
        ' 
        midterm_rst.AutoSize = True
        midterm_rst.Location = New Point(437, 270)
        midterm_rst.Name = "midterm_rst"
        midterm_rst.Size = New Size(14, 15)
        midterm_rst.TabIndex = 24
        midterm_rst.Text = "0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Location = New Point(499, 270)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 15)
        Label7.TabIndex = 25
        Label7.Text = "Final Grade:"
        ' 
        ' final_rst
        ' 
        final_rst.AutoSize = True
        final_rst.Location = New Point(616, 270)
        final_rst.Name = "final_rst"
        final_rst.Size = New Size(14, 15)
        final_rst.TabIndex = 26
        final_rst.Text = "0"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(371, 302)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 20)
        Label6.TabIndex = 27
        Label6.Text = "GWA :"
        ' 
        ' average_rst
        ' 
        average_rst.AutoSize = True
        average_rst.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        average_rst.Location = New Point(433, 302)
        average_rst.Name = "average_rst"
        average_rst.Size = New Size(18, 20)
        average_rst.TabIndex = 28
        average_rst.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(499, 302)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 20)
        Label9.TabIndex = 29
        Label9.Text = "Remarks:"
        ' 
        ' remarks_rst
        ' 
        remarks_rst.AutoSize = True
        remarks_rst.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        remarks_rst.Location = New Point(612, 302)
        remarks_rst.Name = "remarks_rst"
        remarks_rst.Size = New Size(18, 20)
        remarks_rst.TabIndex = 30
        remarks_rst.Text = "0"
        ' 
        ' calculate_btn
        ' 
        calculate_btn.BackColor = SystemColors.ScrollBar
        calculate_btn.Cursor = Cursors.Hand
        calculate_btn.Location = New Point(450, 341)
        calculate_btn.Name = "calculate_btn"
        calculate_btn.Size = New Size(88, 26)
        calculate_btn.TabIndex = 31
        calculate_btn.Text = "CALCULATE"
        calculate_btn.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(midsubject1_tb)
        GroupBox1.Controls.Add(midsubject2_tb)
        GroupBox1.Controls.Add(midsubject3_tb)
        GroupBox1.Controls.Add(midsubject4_tb)
        GroupBox1.Controls.Add(midsubject5_tb)
        GroupBox1.Controls.Add(finsubject1_tb)
        GroupBox1.Controls.Add(finsubject2_tb)
        GroupBox1.Controls.Add(finsubject3_tb)
        GroupBox1.Controls.Add(finsubject4_tb)
        GroupBox1.Controls.Add(subject5_lbl)
        GroupBox1.Controls.Add(finsubject5_tb)
        GroupBox1.Controls.Add(subject4_lbl)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(subject3_lbl)
        GroupBox1.Controls.Add(subject1_lbl)
        GroupBox1.Controls.Add(subject2_lbl)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(309, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(368, 244)
        GroupBox1.TabIndex = 32
        GroupBox1.TabStop = False
        GroupBox1.Text = " GRADE"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Location = New Point(688, 124)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 100)
        GroupBox2.TabIndex = 33
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' Add_Grades
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(689, 379)
        ControlBox = False
        Controls.Add(GroupBox2)
        Controls.Add(calculate_btn)
        Controls.Add(remarks_rst)
        Controls.Add(Label9)
        Controls.Add(average_rst)
        Controls.Add(Label6)
        Controls.Add(final_rst)
        Controls.Add(Label7)
        Controls.Add(midterm_rst)
        Controls.Add(Label5)
        Controls.Add(back_btn)
        Controls.Add(submit_btn)
        Controls.Add(studentnames_cb)
        Controls.Add(subjects_clb)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Add_Grades"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add_Grades"
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents subjects_clb As ListBox
    Friend WithEvents studentnames_cb As ComboBox
    Friend WithEvents submit_btn As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents midsubject1_tb As TextBox
    Friend WithEvents midsubject2_tb As TextBox
    Friend WithEvents midsubject3_tb As TextBox
    Friend WithEvents midsubject4_tb As TextBox
    Friend WithEvents midsubject5_tb As TextBox
    Friend WithEvents finsubject1_tb As TextBox
    Friend WithEvents finsubject2_tb As TextBox
    Friend WithEvents finsubject3_tb As TextBox
    Friend WithEvents finsubject4_tb As TextBox
    Friend WithEvents finsubject5_tb As TextBox
    Friend WithEvents back_btn As Button
    Friend WithEvents subject1_lbl As Label
    Friend WithEvents subject2_lbl As Label
    Friend WithEvents subject3_lbl As Label
    Friend WithEvents subject4_lbl As Label
    Friend WithEvents subject5_lbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents midterm_rst As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents final_rst As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Label6 As Label
    Friend WithEvents average_rst As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents remarks_rst As Label
    Friend WithEvents calculate_btn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
