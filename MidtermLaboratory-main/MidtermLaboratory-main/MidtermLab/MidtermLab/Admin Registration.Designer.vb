<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Registration))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        adminusername_tb = New TextBox()
        adminpassword_tb = New TextBox()
        adminrepassword_tb = New TextBox()
        submit_btn = New Button()
        back_btn = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.ForeColor = Color.White
        Label1.Location = New Point(83, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 17)
        Label1.TabIndex = 0
        Label1.Text = "Admin Username: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(83, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 15)
        Label2.TabIndex = 1
        Label2.Text = "Admin Password: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(83, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 15)
        Label3.TabIndex = 2
        Label3.Text = "Admin Re-Password: "
        ' 
        ' adminusername_tb
        ' 
        adminusername_tb.Location = New Point(231, 73)
        adminusername_tb.Name = "adminusername_tb"
        adminusername_tb.Size = New Size(230, 21)
        adminusername_tb.TabIndex = 3
        ' 
        ' adminpassword_tb
        ' 
        adminpassword_tb.Location = New Point(231, 124)
        adminpassword_tb.Name = "adminpassword_tb"
        adminpassword_tb.Size = New Size(230, 21)
        adminpassword_tb.TabIndex = 4
        ' 
        ' adminrepassword_tb
        ' 
        adminrepassword_tb.BorderStyle = BorderStyle.FixedSingle
        adminrepassword_tb.Location = New Point(231, 181)
        adminrepassword_tb.Name = "adminrepassword_tb"
        adminrepassword_tb.Size = New Size(230, 21)
        adminrepassword_tb.TabIndex = 5
        ' 
        ' submit_btn
        ' 
        submit_btn.BackColor = SystemColors.MenuBar
        submit_btn.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        submit_btn.Location = New Point(309, 233)
        submit_btn.Name = "submit_btn"
        submit_btn.Size = New Size(69, 25)
        submit_btn.TabIndex = 6
        submit_btn.Text = "SUBMIT"
        submit_btn.UseVisualStyleBackColor = False
        ' 
        ' back_btn
        ' 
        back_btn.BackColor = Color.Transparent
        back_btn.BackgroundImage = CType(resources.GetObject("back_btn.BackgroundImage"), Image)
        back_btn.BackgroundImageLayout = ImageLayout.Stretch
        back_btn.Location = New Point(501, 271)
        back_btn.Name = "back_btn"
        back_btn.Size = New Size(32, 28)
        back_btn.TabIndex = 7
        back_btn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(74), CByte(98), CByte(116))
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(45, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(450, 249)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Admin_Registration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(540, 309)
        ControlBox = False
        Controls.Add(back_btn)
        Controls.Add(submit_btn)
        Controls.Add(adminrepassword_tb)
        Controls.Add(adminpassword_tb)
        Controls.Add(adminusername_tb)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Admin_Registration"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin_Registration"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents adminusername_tb As TextBox
    Friend WithEvents adminpassword_tb As TextBox
    Friend WithEvents adminrepassword_tb As TextBox
    Friend WithEvents submit_btn As Button
    Friend WithEvents back_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
