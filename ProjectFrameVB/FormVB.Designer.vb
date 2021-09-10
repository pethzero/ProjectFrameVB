<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblShowText = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtInputText = New System.Windows.Forms.TextBox()
        Me.btnClearText = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnChooseColor = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Leelawadee UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.ProjectFrameVB.My.Resources.Resources.download
        Me.btnSave.Location = New System.Drawing.Point(447, 72)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 62)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "บันทึกข้อมูล"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblShowText
        '
        Me.lblShowText.AutoSize = True
        Me.lblShowText.Font = New System.Drawing.Font("Leelawadee", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowText.ForeColor = System.Drawing.Color.Black
        Me.lblShowText.Location = New System.Drawing.Point(146, 32)
        Me.lblShowText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblShowText.Name = "lblShowText"
        Me.lblShowText.Size = New System.Drawing.Size(56, 23)
        Me.lblShowText.TabIndex = 1
        Me.lblShowText.Text = "Color"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnClose.Location = New System.Drawing.Point(447, 349)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 54)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "ปิดโปรแกรม"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtInputText
        '
        Me.txtInputText.Font = New System.Drawing.Font("Leelawadee", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputText.Location = New System.Drawing.Point(140, 93)
        Me.txtInputText.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInputText.Name = "txtInputText"
        Me.txtInputText.Size = New System.Drawing.Size(281, 24)
        Me.txtInputText.TabIndex = 3
        '
        'btnClearText
        '
        Me.btnClearText.Font = New System.Drawing.Font("Leelawadee UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearText.Location = New System.Drawing.Point(447, 268)
        Me.btnClearText.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClearText.Name = "btnClearText"
        Me.btnClearText.Size = New System.Drawing.Size(150, 54)
        Me.btnClearText.TabIndex = 4
        Me.btnClearText.Text = "ลบช้อมูล"
        Me.btnClearText.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Leelawadee", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(140, 147)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(281, 132)
        Me.ListBox1.TabIndex = 5
        '
        'btnChooseColor
        '
        Me.btnChooseColor.Location = New System.Drawing.Point(26, 87)
        Me.btnChooseColor.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChooseColor.Name = "btnChooseColor"
        Me.btnChooseColor.Size = New System.Drawing.Size(56, 29)
        Me.btnChooseColor.TabIndex = 6
        Me.btnChooseColor.Text = "เลือกสี"
        Me.btnChooseColor.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(26, 149)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "แตงโม"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(26, 171)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox2.TabIndex = 8
        Me.CheckBox2.Text = "มะละกอ"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(26, 194)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox3.TabIndex = 9
        Me.CheckBox3.Text = "มะนาว"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(26, 217)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox4.TabIndex = 10
        Me.CheckBox4.Text = "กล้วย"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 440)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnChooseColor)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnClearText)
        Me.Controls.Add(Me.txtInputText)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblShowText)
        Me.Controls.Add(Me.btnSave)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ทดสอบโปรแกรม"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents lblShowText As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents txtInputText As TextBox
    Friend WithEvents btnClearText As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnChooseColor As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
End Class
