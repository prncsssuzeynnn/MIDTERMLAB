<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateSubject))
        Label1 = New Label()
        subjectcode_tb = New TextBox()
        Button1 = New Button()
        submit_btn = New Button()
        subjectname_tb = New TextBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(129, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 15)
        Label1.TabIndex = 0
        Label1.Text = "Subject Code:"
        ' 
        ' subjectcode_tb
        ' 
        subjectcode_tb.BackColor = Color.White
        subjectcode_tb.Location = New Point(223, 134)
        subjectcode_tb.Name = "subjectcode_tb"
        subjectcode_tb.Size = New Size(102, 21)
        subjectcode_tb.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.Location = New Point(512, 305)
        Button1.Name = "Button1"
        Button1.Size = New Size(36, 24)
        Button1.TabIndex = 4
        Button1.UseVisualStyleBackColor = False
        ' 
        ' submit_btn
        ' 
        submit_btn.BackColor = Color.Ivory
        submit_btn.Cursor = Cursors.Hand
        submit_btn.Location = New Point(253, 260)
        submit_btn.Name = "submit_btn"
        submit_btn.Size = New Size(72, 25)
        submit_btn.TabIndex = 5
        submit_btn.Text = "Submit"
        submit_btn.UseVisualStyleBackColor = False
        ' 
        ' subjectname_tb
        ' 
        subjectname_tb.BackColor = Color.White
        subjectname_tb.Location = New Point(223, 176)
        subjectname_tb.Name = "subjectname_tb"
        subjectname_tb.Size = New Size(179, 21)
        subjectname_tb.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        Label2.FlatStyle = FlatStyle.Flat
        Label2.ForeColor = Color.White
        Label2.Location = New Point(129, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 15)
        Label2.TabIndex = 7
        Label2.Text = "Subject Name:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(118, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(334, 297)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Location = New Point(211, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(154, 128)
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' CreateSubject
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(560, 332)
        ControlBox = False
        Controls.Add(subjectcode_tb)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(subjectname_tb)
        Controls.Add(submit_btn)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "CreateSubject"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CreateSubject"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents subjectcode_tb As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents submit_btn As Button
    Friend WithEvents subjectname_tb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
