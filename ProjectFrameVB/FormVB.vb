Public Class frmMain

    Dim vProgram As String = "ทดสอบ"
    Dim tmpSelect As Integer

    Dim MyColors As List(Of Color) = New List(Of Color)()

    'Dim MyColors() As Color
    'Dim ColorsElements As Integer = 0
    Dim tmpColor As Color = Color.Black
    Dim myStrings() As String
    Dim myStringElements As Integer = 0
    Dim processdraw As Integer = 0
    Dim index As Integer
    Private Sub FormVB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lblShowText.Text = String.Empty
        txtInputText.Text = String.Empty
        ListBox1.DrawMode = DrawMode.OwnerDrawFixed
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("ต้องการออกจากโปรแกรม ???", vProgram, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = vbYes Then
            Me.Close()
        End If
        Exit Sub
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'If txtInputText.Text = String.Empty Then
        '    MessageBox.Show("กรุณาบันทึกข้อมูล")
        '    Exit Sub
        'Else
        '    Dim result As DialogResult = MessageBox.Show("ยืนยันบันทึกข้อมูล", vProgram, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        '    If result = vbYes Then
        '        lblShowText.Text = txtInputText.Text
        '        ListBox1.Items.Add(txtInputText.Text)


        '        lblShowText.Text = String.Empty
        '        txtInputText.Text = String.Empty
        '        'btnSave.BackColor = Color.Red

        '    End If
        '    Exit Sub
        'End If


        If txtInputText.Text = String.Empty Then
            Exit Sub
        End If


        ListBox1.Items.Add(txtInputText.Text)
        MyColors.Add(tmpColor)
        ListBox1.Invalidate()

        'AddElementToColorArray(tmpColor)
        'ListBox1.Invalidate()

        'ListBox1.DrawItem += New DrawItemEventHandler(ListBox1_DrawItem)
        Console.Write(MyColors)


        'ListBox1.ForeColor = tmpColor
        'lblShowText.Text = String.Empty

        lblShowText.ForeColor = tmpColor
        txtInputText.Text = String.Empty
    End Sub

    Private Sub btnClearText_Click(sender As Object, e As EventArgs) Handles btnClearText.Click
        ListBox1.Invalidate()
        If ListBox1.Items.Count <= 0 Then
            Exit Sub
        End If

        MyColors.RemoveAt(0)
        ListBox1.Items.RemoveAt(0)
        txtInputText.Text = String.Empty
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged, ListBox1.Click
        'MessageBox.Show(ListBox1.SelectedItem)
        tmpSelect = ListBox1.SelectedIndex
        ListBox1.Invalidate()

        'MessageBox.Show(ListBox1.SelectedIndex)
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        tmpSelect = ListBox1.SelectedIndex
        If tmpSelect < 0 Then
            Exit Sub
        End If
        MyColors.RemoveAt(tmpSelect)
        ListBox1.Items.RemoveAt(tmpSelect)
        txtInputText.Text = String.Empty
        ListBox1.Invalidate()
    End Sub

    Private Sub btnChooseColor_Click(sender As Object, e As EventArgs) Handles btnChooseColor.Click
        'ColorDialog1.ShowDialog()
        If ColorDialog1.ShowDialog <> DialogResult.Cancel Then
            lblShowText.ForeColor = ColorDialog1.Color
            'txtInputText.ForeColor = ColorDialog1.Color
            tmpColor = ColorDialog1.Color
            Console.Write(tmpColor)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub


    Public Sub AddElementToStringArray(ByVal stringToAdd As String)
        ReDim Preserve myStrings(myStringElements)
        myStrings(myStringElements) = stringToAdd
        myStringElements += 1
    End Sub


    'Add Color
    'Public Sub AddElementToColorArray(ByVal ColorToAdd As Color)
    '    ReDim Preserve MyColors(ColorsElements)
    '    MyColors(ColorsElements) = ColorToAdd
    '    ColorsElements += 1
    'End Sub





    'Change Color
    Private Sub ListBox1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox1.DrawItem

        e.DrawBackground()
        If ListBox1.Items.Count > 0 Then
            e.Graphics.DrawString(TryCast(sender, ListBox).Items(e.Index).ToString, e.Font, New SolidBrush(MyColors(e.Index)), e.Bounds)
        End If
        e.DrawFocusRectangle()


    End Sub

    'Private Sub ListBox1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox1.DrawItem
    '    e.DrawBackground()
    '    If e.Index Mod 2 <> 0 Then 'paint even elements with red
    '        e.Graphics.DrawString(TryCast(sender, ListBox).Items(e.Index).ToString, e.Font, New SolidBrush(Color.Red), e.Bounds)
    '    Else
    '        e.Graphics.DrawString(TryCast(sender, ListBox).Items(e.Index).ToString, e.Font, New SolidBrush(Color.Black), e.Bounds)
    '    End If
    'End Sub
    'Private Sub ListBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ListBox1.DrawItem
    '    '//Draw the background of the ListBox control for each item.
    '    '// Create a new Brush and initialize to a Black colored brush
    '    '// by default.
    '    e.DrawBackground()
    '    Dim mybrush As Brush = Brushes.Black

    '    '// Determine the color of the brush to draw each item based on 
    '    '//the index of the item to draw.
    '    Select Case ListBox1.Items(e.Index).ToString
    '        Case "Error"
    '            mybrush = Brushes.Red
    '        Case "Ready"
    '            mybrush = Brushes.Blue
    '        Case "Success"
    '            mybrush = Brushes.Green
    '    End Select

    '    '//
    '    '// Draw the current item text based on the current 
    '    '// Font and the custom brush settings.
    '    '//
    '    e.Graphics.DrawString(ListBox1.Items(e.Index).ToString(),
    '                          e.Font, mybrush, e.Bounds, StringFormat.GenericDefault)
    '    '//
    '    '// If the ListBox has focus, draw a focus rectangle 
    '    '// around the selected item.
    '    '//
    '    e.DrawFocusRectangle()
    'End Sub


End Class
