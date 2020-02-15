Public Class Form1
    Private dlg As Object
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click, Button1.Click
        Dim open As New OpenFileDialog
        open.Filter = "Website Files|*.htm;*.html"
        If open.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(open.FileName)
        Else
            'Do Nothing
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click, Button2.Click
        dlg.Filter = "Website Files|*.htm;*.html"
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)
        End If
    End Sub

    Private Sub PreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviewToolStripMenuItem.Click, Button3.Click
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form2.Show()
    End Sub
End Class
