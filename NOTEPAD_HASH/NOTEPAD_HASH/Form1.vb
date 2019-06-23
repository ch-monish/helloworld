Public Class Form1
    Private cmd As Process
    Dim i As Integer = 1
    Private Sub EDITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITToolStripMenuItem.Click

    End Sub

    Private Sub NEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWToolStripMenuItem.Click
        MsgBox("DO YOU WANT TO SAVE CHANGES,msgboxstyle.yesnocancle")
        RichTextBox1.Text = ""

    End Sub

    Private Sub OPENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPENToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)



        End If
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)

        End If
    End Sub

    Private Sub PRINTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRINTToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UNDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UNDOToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub COPYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COPYToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub CUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUTToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub PASTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PASTEToolStripMenuItem.Click
        RichTextBox1.Paste()

    End Sub

    Private Sub SELECTALLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECTALLToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub FONTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FONTToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub COLOURToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COLOURToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.ForeColor = ColorDialog1.Color
        End If
    End Sub



    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RUNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RUNToolStripMenuItem.Click
        Process.Start("Cmd.exe")
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim temp As String = RichTextBox1.Text
        RichTextBox1.Text = ""
        RichTextBox1.Text = temp
        RichTextBox1.Find(TextBox4.Text, 0, RichTextBoxFinds.None)
        RichTextBox1.Focus()
        'RichTextBox1.SelectionBackColor = Color.Red

        'Dim index As Integer = 0
        '' Dim temp As String = RichTextBox1.Text
        ''RichTextBox1.Text = ""
        ''RichTextBox1.Text = temp


        'While Index < RichTextBox1.Text.LastIndexOf(TextBox4.Text)
        '    RichTextBox1.Find(TextBox4.Text, Index, RichTextBox1.TextLength, RichTextBoxFinds.None)
        '    '    RichTextBox1.SelectionBackColor = Color.Red

        '    index = RichTextBox1.Text.IndexOf(TextBox4.Text, index) + 1

        'End While

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.SelectedText = TextBox5.Text
        RichTextBox1.SelectedText = ""


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox1.SelectedText = TextBox4.Text.next


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class
