Public Class frmMain

    Dim vProgram As String = "ทดสอบ"
    Dim tmpSelect As Integer
    Dim tmpColor As ColorDialog
    Dim myStrings() As String
    Dim myStringElements As Integer = 0

    Private Sub FormVB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lblShowText.Text = String.Empty
        txtInputText.Text = String.Empty
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("ต้องการออกจากโปรแกรม ???", vProgram, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = vbYes Then
            Me.Close()
        End If
        Exit Sub
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtInputText.Text = String.Empty Then
            MessageBox.Show("กรุณาบันทึกข้อมูล")
            Exit Sub
        Else
            Dim result As DialogResult = MessageBox.Show("ยืนยันบันทึกข้อมูล", vProgram, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = vbYes Then
                lblShowText.Text = txtInputText.Text
                ListBox1.Items.Add(txtInputText.Text)


                lblShowText.Text = String.Empty
                txtInputText.Text = String.Empty
                btnSave.BackColor = Color.Red

            End If
            Exit Sub
        End If
    End Sub

    Private Sub btnClearText_Click(sender As Object, e As EventArgs) Handles btnClearText.Click
        If tmpSelect < 0 Then
            Exit Sub
        End If
        ListBox1.Items.RemoveAt(tmpSelect)
        btnSave.BackColor = Color.Gray
        lblShowText.Text = String.Empty
        txtInputText.Text = String.Empty
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged, ListBox1.Click
        'MessageBox.Show(ListBox1.SelectedItem)
        tmpSelect = ListBox1.SelectedIndex
        'MessageBox.Show(ListBox1.SelectedIndex)
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        tmpSelect = ListBox1.SelectedIndex
        If tmpSelect < 0 Then
            Exit Sub
        End If
        ListBox1.Items.RemoveAt(tmpSelect)
        lblShowText.Text = String.Empty
        txtInputText.Text = String.Empty
    End Sub

    Private Sub btnChooseColor_Click(sender As Object, e As EventArgs) Handles btnChooseColor.Click
        'ColorDialog1.ShowDialog()
        If ColorDialog1.ShowDialog <> DialogResult.Cancel Then
            lblShowText.ForeColor = ColorDialog1.Color
            txtInputText.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'If CheckBox1.Checked = True Then
        '    ListBox1.Items.Add(CheckBox1.Text)
        'Else
        '    ListBox1.Items.RemoveAt(tmpSelect)
        'End If
        Dim i As Integer
        For i = 1 To 5
            AddElementToStringArray("MyString " & i & ".")
        Next

        Console.Write(myStrings)
        Me.lblShowText.Text = ("Number of elements in array is: " & myStrings.Length)

    End Sub

    Public Sub AddElementToStringArray(ByVal stringToAdd As String)
        ReDim Preserve myStrings(myStringElements)
        myStrings(myStringElements) = stringToAdd
        myStringElements += 1
    End Sub

End Class
