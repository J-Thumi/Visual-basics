<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        PictureBox1 = New PictureBox()
        GroupBox3 = New GroupBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        GroupBox4 = New GroupBox()
        RadioButton6 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        Button1 = New Button()
        Button2 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 100)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Display Text"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 22)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Sample Test"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton3)
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Location = New Point(276, 0)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(494, 100)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Font"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton3.Location = New Point(339, 43)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(69, 18)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Tahoma"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Magneto", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(162, 43)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(82, 20)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Magneto"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Garamond", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(21, 40)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(75, 17)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Garamond"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(21, 161)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(265, 182)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(CheckBox3)
        GroupBox3.Controls.Add(CheckBox2)
        GroupBox3.Controls.Add(CheckBox1)
        GroupBox3.Location = New Point(333, 161)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(200, 182)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Font Style"
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CheckBox3.Location = New Point(27, 125)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(85, 19)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Bold Italic"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox2.Location = New Point(27, 89)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(51, 19)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Bold"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(26, 53)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(51, 19)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Italic"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(RadioButton6)
        GroupBox4.Controls.Add(RadioButton5)
        GroupBox4.Controls.Add(RadioButton4)
        GroupBox4.Location = New Point(550, 161)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(200, 182)
        GroupBox4.TabIndex = 4
        GroupBox4.TabStop = False
        GroupBox4.Text = "Font Color"
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(32, 137)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(45, 19)
        RadioButton6.TabIndex = 2
        RadioButton6.TabStop = True
        RadioButton6.Text = "Red"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(29, 95)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(48, 19)
        RadioButton5.TabIndex = 1
        RadioButton5.TabStop = True
        RadioButton5.Text = "Blue"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(29, 52)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(56, 19)
        RadioButton4.TabIndex = 0
        RadioButton4.TabStop = True
        RadioButton4.Text = "Green"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(75, 387)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 32)
        Button1.TabIndex = 5
        Button1.Text = "Load Picture"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(615, 387)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 35)
        Button2.TabIndex = 6
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form2"
        Text = "Object Demonstrations"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
